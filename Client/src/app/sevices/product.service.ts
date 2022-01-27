import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../models/product.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http:HttpClient) {
   }

   getProducts():Observable<Product[]>{
     return this.http.get<Product[]>("https://localhost:44316/api/Products");
               
   }
}
