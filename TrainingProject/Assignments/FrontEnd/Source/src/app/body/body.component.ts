import { Component, OnInit } from '@angular/core';
import { HttpErrorResponse } from '@angular/common/http';
import { CategoryService } from '../services/category.service';
import { ICategories } from '../model/categories';
import { OffersService } from '../services/offers.service';
import { IOffers } from '../model/offers';
import { HArticleService } from '../services/h-article.service';
import {Iharticle} from '../model/harticle';
import { ClientArticlesService } from '../services/client-articles.service';
import { IclientArticle } from '../model/clientArticles';


@Component({
  selector: 'app-body',
  templateUrl: './body.component.html',
  styleUrls: ['./body.component.css']
})
export class BodyComponent implements OnInit {

  constructor(private category:CategoryService,private offer:OffersService,private health:HArticleService, private article:ClientArticlesService) { }
  offers:IOffers[] =[];
  offersdetails : IOffers | undefined;
  healtharticles:Iharticle [] = [];
  healtharticlesdetails:Iharticle | undefined;
  articles:IclientArticle[] = [];
  articlesdetails:IclientArticle | undefined;


  categories:ICategories[] = [];
  categoriesdetails:ICategories | undefined;

  ngOnInit(): void {
    this.GetCategories();
    this.GetHarticle();
    this.Getoffers();
    this. GetCarticle();
  }

  GetCategories(){
    this.category.GetCategories().subscribe
   ((res:any)=>{console.log(res);
  this.categories = res.sort();
    console.log(this.categories[0].cat_Name);
  },
  (err:HttpErrorResponse)=>{
    console.log(err.message);
  }
  )
    }
    GetHarticle(){
      this.health.GetHarticle().subscribe
     ((res:any)=>{console.log(res);
    this.healtharticles = res.sort();
      console.log(this.healtharticles[1].h_Heading);
    },
    (err:HttpErrorResponse)=>{
      console.log(err.message);
    }
    )
      }
    
    Getoffers(){
      this.offer.GetOffers().subscribe
     ((res:any)=>{console.log(res);
    this.offers = res.sort();
  
    },
    (err:HttpErrorResponse)=>{
      console.log(err.message);
    }
    )
      }

      GetCarticle(){
        this.article.GetCarticle().subscribe
       ((res:any)=>{console.log(res);
      this.articles = res.sort();
      console.log(this.articles[0].a_Discription);
      },
      (err:HttpErrorResponse)=>{
        console.log(err.message);
      }
      )
        }
  
}
