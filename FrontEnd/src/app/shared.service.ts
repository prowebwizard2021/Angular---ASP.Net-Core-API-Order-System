import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  readonly APIUrl="https://localhost:5001/WeatherForecast";

constructor(private http:HttpClient) { }

  getOrderlist():Observable<any[]>{
    return this.http.get<any>(this.APIUrl);
  }

  addOrder(val:any){
    return this.http.post(this.APIUrl,val)
  }

  updateOrder(val:any) {
    return this.http.put(this.APIUrl,val)
  }

  deleteOrder(val:any) {
    return this.http.delete(this.APIUrl+val)
  }
}
