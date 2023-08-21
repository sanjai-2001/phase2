import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Product } from 'src/Models/Product';
import { TemporaryService } from '../temporary.service';


@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
   products!: Product[];

ngOnInit(){
  this.getProducts();
}

constructor(public router:Router,public temp:TemporaryService){}

  public getProducts() {
    
    this.products = [
        new Product(1, 'Memory Card', 500),
        new Product(2, 'Pen Drive', 750),
        new Product(3, 'Power Bank', 100)
    ]
    return this.products;
}
public getProduct(id: number) {
    let products:Product[]=this.getProducts();
    this.temp.detailParameter= products.find(p => p.productID==id);
    this.router.navigate(['/detail']);

   }

}
