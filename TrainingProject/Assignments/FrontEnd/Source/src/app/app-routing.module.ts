import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { BodyComponent } from './body/body.component';
import { CartComponent } from './cart/cart.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { CategoriesComponent } from './categories/categories.component';
import { PostComponent } from './post/post.component';
import { UsersComponent } from './users/users.component';
import { combineLatestInit } from 'rxjs/internal/observable/combineLatest';
import { OffersComponent } from './offers/offers.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { BaidyanathComponent } from './categories/baidyanath/baidyanath.component';
import { CovidEssentialComponent } from './categories/covid-essential/covid-essential.component';
import { PersonalCareComponent } from './categories/personal-care/personal-care.component';
import { HealthFoodDriksComponent } from './categories/health-food-driks/health-food-driks.component';
import { BeautyComponent } from './categories/beauty/beauty.component';
import { SkinCareComponent } from './categories/skin-care/skin-care.component';
import { HomeCareComponent } from './categories/home-care/home-care.component';
import { AyurvedicCareComponent } from './categories/ayurvedic-care/ayurvedic-care.component';
import { SexualWellnessComponent } from './categories/sexual-wellness/sexual-wellness.component';
import { FitnessSupplementsComponent } from './categories/fitness-supplements/fitness-supplements.component';
import { MotherAndBabyCareComponent } from './categories/mother-and-baby-care/mother-and-baby-care.component';
import { HealthCareDevicesComponent } from './categories/health-care-devices/health-care-devices.component';
import { HealthConditionComponent } from './categories/health-condition/health-condition.component';
import { DiabeticCareComponent } from './categories/diabetic-care/diabetic-care.component';
import { ElderlyCareComponent } from './categories/elderly-care/elderly-care.component';
import { AccessoriesAndWearablesComponent } from './categories/accessories-and-wearables/accessories-and-wearables.component';
import { TopProductsComponent } from './categories/top-products/top-products.component';
import { PpeKitComponent } from './categories/covid-essential/ppe-kit/ppe-kit.component';


const routes: Routes = [
  {path:'', 
  redirectTo : 'body', 
  pathMatch:'full'},
  { path: 'header', component: HeaderComponent },
  { path: 'footer', component: FooterComponent },
  { path: 'body', component: BodyComponent },
  { path: 'cart', component: CartComponent },
  { path: 'user', component: UsersComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'post', component: PostComponent },
  { 
    path: 'categories', 
    component: CategoriesComponent,
    // children: [
    //   {
    //     path: 'bhidyanath', // child route path
    //     component: BaidyanathComponent, // child route component that the router renders
    //   }
      
    // ],

  },
  {
    path:'baidyanath',
    component: BaidyanathComponent,
  },
  {
    path:"covid-essential",
    component:CovidEssentialComponent
  },
  {
    path:"ppe-kit",
    component:PpeKitComponent
  },
 {
  path:"peronal-care",
  component:PersonalCareComponent
 },
  {
    path:"Health-Food",
    component:HealthFoodDriksComponent
  },
  {
    path:"Beauty",
    component:BeautyComponent
  },
  {
    path:"skin-care",
    component:SkinCareComponent
  },
  {
    path:"Home-Care",
    component:HomeCareComponent
  },
  {
    path:"ayurvedic-care",
    component:AyurvedicCareComponent
  },
  {
    path:"sexual",
    component:SexualWellnessComponent
  },
  {
    path:"fitness",
    component:FitnessSupplementsComponent
  },
  {
    path:"mother",
    component:MotherAndBabyCareComponent
  },

  {
    path:"Health-Care",
    component:HealthCareDevicesComponent
  },
  {
    path:"Health-condition",
    component:HealthConditionComponent
  },
{
  path:"diabetic",
  component:DiabeticCareComponent
},
{
path:"eldery",
component:ElderlyCareComponent
},
{
path:"Accesories",
component:AccessoriesAndWearablesComponent
},
{
path:"Top-Products",
component:TopProductsComponent
},
  { 
      path: 'offers', 
      component: OffersComponent 
  },
  
  {
    path:"**",
    component:PageNotFoundComponent
  }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, {
     
    }),
  ],
  exports: [RouterModule],
})
export class AppRoutingModule {}
