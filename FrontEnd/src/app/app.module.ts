import { OrderServiceService } from './services/OrderService.service';
import { SharedService } from './shared.service';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';

import { MatButtonModule } from '@angular/material/button';
import { MatListModule } from '@angular/material/list';
import { MatToolbarModule } from '@angular/material/toolbar';
// import { MatInput } from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';
import { MatNativeDateModule } from '@angular/material/core';
// import { DemoMaterialModule } from '@angular/material-module';
import {MatInputModule} from '@angular/material/input';
import {MatSelectModule} from '@angular/material/select';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatTabsModule} from '@angular/material/tabs';
import {MatAutocompleteModule} from '@angular/material/autocomplete';

import { MsalModule, MsalInterceptor } from '@azure/msal-angular';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { NgbNavModule, NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { OrderListComponent } from './OrderList/OrderList.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DashboardComponent } from './dashboard/dashboard.component';
import { EditDashboardComponent } from './edit-dashboard/edit-dashboard.component';
import { StoreModule } from '@ngrx/store';
import { apiReducer } from './store/api.reducer';

import { LOCALE_ID } from '@angular/core';
import localePt from '@angular/common/locales/de';
import { registerLocaleData } from '@angular/common';
import { PricingModal1Component } from './dashboard/pricing-modal1/pricing-modal1.component';
import { PricingModal2Component } from './dashboard/pricing-modal2/pricing-modal2.component';
import { StyleModalComponent } from './dashboard/style-modal/style-modal.component';
import { FactoryModalComponent } from './dashboard/factory-modal/factory-modal.component';
import { PurchaseModal1Component } from './dashboard/style-modal/purchase-modal1/purchase-modal1.component';
import { PurchaseModal2Component } from './dashboard/style-modal/purchase-modal2/purchase-modal2.component';
import { HomeSliderComponent } from './components/home-slider/home-slider.component';
import { OrderDetailComponent } from './components/edit-dashboard/order-detail/order-detail.component';
import { OrderOverviewComponent } from './components/edit-dashboard/order-overview/order-overview.component';
import { AccountOverviewComponent } from './components/edit-dashboard/account-overview/account-overview.component';
import { EditActionsComponent } from './components/edit-dashboard/edit-actions/edit-actions.component';

registerLocaleData(localePt, 'de');

const isIE = window.navigator.userAgent.indexOf('MSIE ') > -1 || window.navigator.userAgent.indexOf('Trident/') > -1;

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    OrderListComponent,
    DashboardComponent,
    EditDashboardComponent,
    PricingModal1Component,
    PricingModal2Component,
    StyleModalComponent,
    FactoryModalComponent,
    PurchaseModal1Component,
    PurchaseModal2Component,
    HomeSliderComponent,
    OrderDetailComponent,
    OrderOverviewComponent,
    AccountOverviewComponent,
    EditActionsComponent
  ],
  entryComponents: [
    PricingModal1Component,
    PricingModal2Component,
    StyleModalComponent,
    FactoryModalComponent,
    PurchaseModal1Component,
    PurchaseModal2Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MatToolbarModule,
    MatSelectModule,
    MatDatepickerModule,
    MatTabsModule,
    MatAutocompleteModule,
   // DemoMaterialModule,
    MatNativeDateModule,
    MatFormFieldModule,
    MatButtonModule,
 //   MatInput,
    MatInputModule,
    MatListModule,
    AppRoutingModule,
    NgbNavModule,
    MsalModule.forRoot({
      auth: {
        clientId: '22db4210-6a8f-4538-a645-ab8f4256b4fd',
        authority: 'https://login.microsoftonline.com/dbabede6-6a16-4689-932a-f1297802932e',
        redirectUri: 'http://localhost:4200',
      },
      cache: {
        cacheLocation: 'localStorage',
        storeAuthStateInCookie: isIE, // set to true for IE 11
      },
    },
    {
      popUp: !isIE,
      consentScopes: [
        'user.read',
        'openid',
        'profile',
      ],
      protectedResourceMap: [
        ['Enter_the_Graph_Endpoint_Herev1.0/me', ['user.read']]
      ],
      extraQueryParameters: {}
    }),
    NgbModule,
    StoreModule.forRoot({data: apiReducer}),
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: MsalInterceptor,
      multi: true
    },
    { provide: LOCALE_ID, useValue: 'de' },
    SharedService,
    OrderServiceService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
