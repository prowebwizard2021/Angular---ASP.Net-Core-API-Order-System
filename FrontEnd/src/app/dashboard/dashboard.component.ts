import { Component, OnInit } from '@angular/core';
import { Store } from '@ngrx/store';
import { OrderServiceService } from './../services/OrderService.service';
import { OrderDetail } from '../models/OrderDetail';
import { MsalService } from '@azure/msal-angular';
import { HttpClient } from '@angular/common/http';
import { InteractionRequiredAuthError, AuthError } from 'msal';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { PricingModal1Component } from './pricing-modal1/pricing-modal1.component';
import { PricingModal2Component } from './pricing-modal2/pricing-modal2.component';
import { StyleModalComponent } from './style-modal/style-modal.component';
import { Observable } from 'rxjs';
import { FormControl } from '@angular/forms';
import { startWith, map } from 'rxjs/operators';
import { FactoryModalComponent } from './factory-modal/factory-modal.component';

import * as _moment from 'moment';

const moment = require('moment');

const GRAPH_ENDPOINT = 'https://graph.microsoft.com/v1.0/me';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  profile;
  loading = false;
  Order: OrderDetail = {
    id: null,
    orderStatus: null,
    orderId: null,
    additionalCode: null,
    title: null,
    titleEN: null,
    customer: {
      title: null,
      id: null
    },
    customers: [],
    productCategory: null,
    productCategories: [],
    season: null,
    seasons: [],
    deliveryDateFrom: null,
    deliveryDateTo: null,
    quantityOrderedByClient: null,
    quantityPlacedAtFactory: null,
    costumerArticleNumber: null,
    shipmentDate: null,
    country: null,
    countries: [],
    factoryFixed: null,
    purchasePrice1: null,
    purchasePrice2: null,
    purchasePrice3: null,
    exchangeRatePurchasePrice: null,
    rateOfDutyPurchasePrice: null,
    vkgp: null,
    vkgpNachLB: null,
    exchangeRateVK: null,
    ekNotFixed: null,
    merchandiserQB: null,
    orderPlacedAtCustomer: null,
    termsOfDeliveryIncoming: {
      title: null,
      id: null
    },
    termsOfDeliveryIncomings: [],
    termsOfDeliveryOutgoing: {
      title: null,
      id: null
    },
    termsOfDeliveryOutgoings: [],
    termsOfDeliveryFixed: null,
    factories: [],
    mainFactory: null,
    factoryGroups: [],
    factoryGroup: {
      title: null,
      id: null
    },
    cartonCount: null,
    otherOrders: [],
    currency: {
      title: null,
      id: null
    },
    currencies: [],
    ekAufschlag: null,
    currencyEKAufschlag: null,
    currencyVK: {
      title: null,
      id: null
    },
    packingQB: null,
    orderPlacedAtSupplier: null,
    termsOfPayment: null,
    termsOfPayments: [],
    lcStatus: null,
    lcStatuses: [],
    blReceived: null,
    testingLab: null,
    testingLabs: [],
    originalSamplePick: null,
    newSamplePick: null,
    samplePickShortResult: null,
    samplePickShortResults: [],
    department: null,
    departments: [],
    procurementQB: null,
    merchandiserSupplier: null,
    qc: null,
    knitWoven: null,
    fMReceivedDate: null,
    cdExDate: null,
    testingLaboratory: null,
    revisedETD: null,
    latestETA: null,
    fabricsFromCountry: null,
    friLab: null,
    friLabs: [],
    fri1date: null,
    latestfridate: null,
    fri1Quantity: null,
    fri1Result: null,
    fri2date: null,
    fri2Quantity: null,
    fri2Result: null,
    fri3date: null,
    fri3Quantity: null,
    fri3Result: null,
    reportAldiDate: null,
    forwarderFreight: null,
    forwarderDelivery: null,
    blReceivedDate: null,
    vessel: null,
    keyAccounter: null,
    inspectionCosts: null,
    airFreightCosts: null,
    spFinalResult: null,
    ba: null,
    orderStyles: [],
    otherFactories: [],
    markupTypes: [],
    markDownTypes: [],
    markups: [],
    markdowns: [],
    customerArticleNumber: null,
    lot: null,
    supplierDeliveryDateOriginal: null,
    supplierDeliveryDateNew: null,
    supplierDeliveryDateLastPossibility: null,
    shipmentDateNew: null,
    shipname: null,
    endCustomer: null,
    endCustomers: [],
    isOrderWithoutFixedCustomer: null
  };

  markupTable: MarkupData[] = [
    {type: 'Type A', markup: '0.24', currency: '100', rate : '1.1' },
    {type: 'Type A', markup: '0.24', currency: '100', rate : '1.1' },
    {type: 'Type A', markup: '0.24', currency: '100', rate : '1.1' },
  ];

  markdownTable: MarkdownData[] = [
    {type: 'Type A', markdown: '0.24', currency: '100', rate : '1.1' },
    {type: 'Type A', markdown: '0.24', currency: '100', rate : '1.1' },
    {type: 'Type A', markdown: '0.24', currency: '100', rate : '1.1' },
  ];

  myControl = new FormControl();
  filteredOptions: Observable<string[]>;


  constructor(
    public dialog: MatDialog,
    private store: Store<any>,
    private authService: MsalService,
    private http: HttpClient,
    private route: ActivatedRoute,
    private router: Router,
    private orderService: OrderServiceService
    ) {}

  ngOnInit() {
    this.getProfile();

    const heroId = this.route.snapshot.paramMap.get('id');
    this.orderService.GetOrder(heroId)
    .subscribe(hero => {
    this.Order = hero;
    console.log('OrderFromBackend: ', this.Order);
    });
    this.filteredOptions = this.myControl.valueChanges.pipe(
      startWith(''),
      map(val => this.filter(val))
    );
  }

  filter(val: string): string[] {
    return this.Order.factories.map(x => x.title).filter(option =>
      option.toLowerCase().includes(val.toLowerCase()));
  }

  getProfile() {
    this.http.get(GRAPH_ENDPOINT)
    .subscribe({
      next: (profile) => {
        this.profile = profile;
      },
      error: (err: AuthError) => {
        // If there is an interaction required error,
        // call one of the interactive methods and then make the request again.
        if (InteractionRequiredAuthError.isInteractionRequiredError(err.errorCode)) {
          this.authService.acquireTokenPopup({
            scopes: this.authService.getScopesForEndpoint(GRAPH_ENDPOINT)
          })
          .then(() => {
            this.http.get(GRAPH_ENDPOINT)
              .toPromise()
              .then(profile => {
                this.profile = profile;
              });
          });
        }
      }
    });
  }

  openPricingModal1(isEdit, index): void{
    let data = null;
    if (isEdit) {
      data = this.markupTable[index];
    }
    const dialogRef = this.dialog.open(PricingModal1Component, {
      width: '550px',
      data: {
        isEdit,
        data
      }
    });

    dialogRef.afterClosed().subscribe(res => {
      console.log(res);
      if (res) {
        if (isEdit) {
          this.markupTable[index] = res;
        } else {
          this.markupTable.push(res);
        }
      }
    });
  }
  openPricingModal2(isEdit, index): void{
    let data = null;
    if (isEdit) {
      data = this.markdownTable[index];
    }
    const dialogRef = this.dialog.open(PricingModal2Component, {
      width: '550px',
      data: {
        isEdit,
        data
      }
    });

    dialogRef.afterClosed().subscribe(res => {
        console.log(res);
        if (res) {
          if (isEdit) {
            this.markdownTable[index] = res;
          } else {
            this.markdownTable.push(res);
          }
        }
    });
  }

  removeMarkup(index) {
    this.markupTable.splice(index, 1);
  }

  removeMarkdown(index) {
    this.markdownTable.splice(index, 1);
  }

  openStyleModal(isEdit, index): void{
    let data = null;
    if (isEdit) {
      data = this.Order.orderStyles[index];
    }
    const dialogRef = this.dialog.open(StyleModalComponent, {
      height: '90%',
      data: {
        isEdit,
        data
      }
    });

    dialogRef.afterClosed().subscribe(res => {
      console.log(res);
      console.log('order: ', this.Order);
      console.log('orderStyles: ', this.Order.orderStyles);
      if (res) {
        if (isEdit) {
          this.Order.orderStyles[index] = res;
        } else {
          this.Order.orderStyles.push(res);
        }
      }
    });
  }

  removeStyle(index) {
    this.Order.orderStyles.splice(index, 1);
  }

  factoryModal() {
    const dialogRef = this.dialog.open(FactoryModalComponent, {
      data: this.Order.factories
    });

    dialogRef.afterClosed().subscribe(res => {
      console.log(res);
      if (res) {
        this.Order.otherOrders.push(res);
      }
    });
  }

  removeFactory(index) {
    this.Order.otherOrders.splice(index, 1);
  }

  save() {
    const momentToDate = moment(this.Order.deliveryDateFrom).toDate();
    this.Order.deliveryDateFrom = new Date(Date.UTC(momentToDate.getFullYear(), momentToDate.getMonth(), momentToDate.getDate(),
    momentToDate.getHours(), momentToDate.getMinutes(), momentToDate.getSeconds()));

    const momentToDate2 = moment(this.Order.deliveryDateTo).toDate();
    this.Order.deliveryDateTo = new Date(Date.UTC(momentToDate2.getFullYear(), momentToDate2.getMonth(), momentToDate2.getDate(),
    momentToDate2.getHours(), momentToDate2.getMinutes(), momentToDate2.getSeconds()));

    const momentToDate3 = moment(this.Order.supplierDeliveryDateLastPossibility).toDate();
    this.Order.supplierDeliveryDateLastPossibility = new Date(Date.UTC(momentToDate3.getFullYear(),
    momentToDate3.getMonth(), momentToDate3.getDate(), momentToDate3.getHours(), momentToDate3.getMinutes(), momentToDate3.getSeconds()));

    const momentToDate4 = moment(this.Order.supplierDeliveryDateNew).toDate();
    this.Order.supplierDeliveryDateNew = new Date(Date.UTC(momentToDate4.getFullYear(),
    momentToDate4.getMonth(), momentToDate4.getDate(), momentToDate4.getHours(), momentToDate4.getMinutes(), momentToDate4.getSeconds()));

    const momentToDate5 = moment(this.Order.supplierDeliveryDateOriginal).toDate();
    this.Order.supplierDeliveryDateOriginal = new Date(Date.UTC(momentToDate5.getFullYear(),
    momentToDate5.getMonth(), momentToDate5.getDate(), momentToDate5.getHours(), momentToDate5.getMinutes(), momentToDate5.getSeconds()));

    const momentToDate6 = moment(this.Order.shipmentDate).toDate();
    this.Order.shipmentDate = new Date(Date.UTC(momentToDate6.getFullYear(),
    momentToDate6.getMonth(), momentToDate6.getDate(), momentToDate6.getHours(), momentToDate6.getMinutes(), momentToDate6.getSeconds()));

    const momentToDate7 = moment(this.Order.shipmentDateNew).toDate();
    this.Order.shipmentDateNew = new Date(Date.UTC(momentToDate7.getFullYear(),
    momentToDate7.getMonth(), momentToDate7.getDate(), momentToDate7.getHours(), momentToDate7.getMinutes(), momentToDate7.getSeconds()));

    const momentToDate8 = moment(this.Order.orderPlacedAtSupplier).toDate();
    this.Order.orderPlacedAtSupplier = new Date(Date.UTC(momentToDate8.getFullYear(),
    momentToDate8.getMonth(), momentToDate8.getDate(), momentToDate8.getHours(), momentToDate8.getMinutes(), momentToDate8.getSeconds()));

    const momentToDate9 = moment(this.Order.latestfridate).toDate();
    this.Order.latestfridate = new Date(Date.UTC(momentToDate9.getFullYear(),
    momentToDate9.getMonth(), momentToDate9.getDate(), momentToDate9.getHours(), momentToDate9.getMinutes(), momentToDate9.getSeconds()));

    const momentToDate10 = moment(this.Order.fri1date).toDate();
    this.Order.fri1date = new Date(Date.UTC(momentToDate10.getFullYear(), momentToDate10.getMonth(),
    momentToDate10.getDate(), momentToDate10.getHours(), momentToDate10.getMinutes(), momentToDate10.getSeconds()));

    const momentToDate11 = moment(this.Order.latestETA).toDate();
    this.Order.latestETA = new Date(Date.UTC(momentToDate11.getFullYear(), momentToDate11.getMonth(),
    momentToDate11.getDate(), momentToDate11.getHours(), momentToDate11.getMinutes(), momentToDate11.getSeconds()));

    const momentToDate12 = moment(this.Order.originalSamplePick).toDate();
    this.Order.originalSamplePick = new Date(Date.UTC(momentToDate12.getFullYear(), momentToDate12.getMonth(),
    momentToDate12.getDate(), momentToDate12.getHours(), momentToDate12.getMinutes(), momentToDate12.getSeconds()));

    const momentToDate13 = moment(this.Order.newSamplePick).toDate();
    this.Order.newSamplePick = new Date(Date.UTC(momentToDate13.getFullYear(), momentToDate13.getMonth(),
    momentToDate13.getDate(), momentToDate13.getHours(), momentToDate13.getMinutes(), momentToDate13.getSeconds()));

    const momentToDate14 = moment(this.Order.blReceivedDate).toDate();
    this.Order.blReceivedDate = new Date(Date.UTC(momentToDate14.getFullYear(), momentToDate14.getMonth(),
    momentToDate14.getDate(), momentToDate14.getHours(), momentToDate14.getMinutes(), momentToDate14.getSeconds()));

    this.loading = true;
    // this.orderService.PutOrder(this.Order.id, this.Order).subscribe(x => console.log(x), er => console.error(er));
    
    this.orderService.PutOrder(this.Order.id, this.Order).subscribe(x => {
      alert('Erfolgreich gespeichert'),
      console.log(x.id);
      window.location.href = '/dashboard/'+x.id;
    }, er => console.error(er));
  }

  delete() {
    this.orderService.DeleteOrder(this.Order.id).subscribe(x => console.log(x), er => console.error(er));

  }

}


export interface MarkupData {
  type: string;
  markup: string;
  currency: string;
  rate: string;
}
export interface MarkdownData {
  type: string;
  markdown: string;
  currency: string;
  rate: string;
}
