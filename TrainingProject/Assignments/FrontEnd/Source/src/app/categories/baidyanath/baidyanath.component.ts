import { Component, OnInit } from '@angular/core';
import { ProductserviceService } from 'src/app/services/productservice.service';
import { IProduct } from '../../model/product';
// import { CategoryService } from '../../services/category.service';
// import { ICategories } from '../../model/categories';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-baidyanath',
  templateUrl: './baidyanath.component.html',
  styleUrls: ['./baidyanath.component.css']
})
export class BaidyanathComponent implements OnInit {

  constructor(private pro:ProductserviceService) { }
  products:IProduct[] = [];
  productsdetails:IProduct | undefined;

  ngOnInit(): void {
  
    this.GetProducts()
  }
  
    GetProducts(){
      this.pro.GetProducts().subscribe
      ((res:any)=>{console.log(res);;
        this.products=res.sort();
        console.log(this.products[0].pr_Name);
      },
      (err:HttpErrorResponse)=>{
        console.log(err.message);
      }
      )
    }
}
