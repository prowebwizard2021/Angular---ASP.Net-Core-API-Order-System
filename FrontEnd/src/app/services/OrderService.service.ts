import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { OrderDetail } from '../models/OrderDetail';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class OrderServiceService {

  baseUrl = 'https://localhost:5001/';

constructor(private httpClient: HttpClient) { }

  GetOrder(id): Observable<OrderDetail> {
    return this.httpClient.get<OrderDetail>(this.baseUrl + 'WeatherForecast/' + id);
  }

  PutOrder(id: number, order: OrderDetail): Observable<any> {
    return this.httpClient.put<OrderDetail>(`${this.baseUrl}WeatherForecast/${id}`, order);
  }

  DeleteOrder(id: number): Observable<any> {
    return this.httpClient.delete(`${this.baseUrl}WeatherForecast/${id}`);
  }
}
