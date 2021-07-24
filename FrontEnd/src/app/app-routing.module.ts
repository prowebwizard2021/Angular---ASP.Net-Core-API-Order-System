import { OrderListComponent } from './OrderList/OrderList.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MsalGuard } from '@azure/msal-angular';
import { HomeComponent } from './home/home.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { EditDashboardComponent } from './edit-dashboard/edit-dashboard.component';

const routes: Routes = [
  {
    path: 'OrderList',
    component: OrderListComponent,
    canActivate: [
      MsalGuard
    ]
  },
  {
    path: 'dashboard/:id',
    component: DashboardComponent,
    // canActivate: [
    //   MsalGuard
    // ]
  },
  {
    path: 'edit-dashboard',
    component: EditDashboardComponent
  },
  {
    path: '',
    component: HomeComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: false, relativeLinkResolution: 'legacy' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
