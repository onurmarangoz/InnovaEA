import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product.model';
import { ProductService } from '../sevices/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  constructor(private productService:ProductService) { }

  products:Product[] = [];

  ngOnInit(): void {
     this.productService.getProducts() 
                        .subscribe((data:Product[])=>this.products=data);
  }

  showData(event:HTMLInputElement){
    console.log(event);
  }

}
