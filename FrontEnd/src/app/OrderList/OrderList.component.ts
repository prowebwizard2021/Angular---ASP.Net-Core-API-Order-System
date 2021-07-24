import { Router, ActivatedRoute } from '@angular/router';
import { SharedService } from './../shared.service';
import { Component, OnInit } from '@angular/core';
import { MsalService } from '@azure/msal-angular';
import { HttpClient } from '@angular/common/http';
import { InteractionRequiredAuthError, AuthError } from 'msal';
import { Observable } from 'rxjs';
import { switchMap } from 'rxjs/operators';

const GRAPH_ENDPOINT = 'https://graph.microsoft.com/v1.0/me';

@Component({
  selector: 'app-OrderList',
  templateUrl: './OrderList.component.html',
  styleUrls: ['./OrderList.component.css']
})
export class OrderListComponent implements OnInit {
  profile;

  constructor(private authService: MsalService,
              private http: HttpClient,
              private service: SharedService,
              private activatedRouter: Router,
              private router: Router) { }

  OrderList: any = [];
  page = 1;
  pageSize = 15;
  selectedId: number;

  OrderIdFilter: string = '';
  OrderCustomerFilter: string = '';
  OrderListWithoutFilter: any = [];

  roles;
  name: string;
  username: string;

  ngOnInit() {
    const account = this.authService.getAccount();
    this.name = account.name;
    this.username = account.userName;
    this.roles = account.idToken.roles;

    this.getProfile();
    this.refreshOrderList();
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

  refreshOrderList(){
    this.service.getOrderlist().subscribe(data =>{
      this.OrderList = data;
      this.OrderListWithoutFilter = data;
    });
  }

  FilterFn(){
    var OrderListIdFilter = this.OrderIdFilter;
    var OrderListCustomerFilter = this.OrderCustomerFilter;

    this.OrderList = this.OrderListWithoutFilter.filter(function (el) {
      return el.orderId.toString().toLowerCase().includes(
        OrderListIdFilter.toString().trim().toLowerCase()
      )&&
      el.customer.toString().toLowerCase().includes(
        OrderListCustomerFilter.toString().trim().toLowerCase()
      )
    });
  }

  sortResult(prop, direction) {
    this.OrderList = this.OrderListWithoutFilter.sort(function(a, b){
      if(direction){
        return (a[prop] > b[prop]) ? 1 : ((a[prop] < b[prop]) ? - 1 : 0);
      } else{
        return (b[prop] > a[prop]) ? 1 : ((b[prop] < a[prop]) ? - 1 :0 );
      }
    });
  }
}
