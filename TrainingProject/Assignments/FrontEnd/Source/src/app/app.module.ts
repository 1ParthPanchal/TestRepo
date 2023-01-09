import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { BodyComponent } from './body/body.component';
import { LoginComponent } from './login/login.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { CartComponent } from './cart/cart.component';
import { CategoriesComponent } from './categories/categories.component';
import { PostComponent } from './post/post.component';
import { UsersComponent } from './users/users.component';
import { NgOtpInputModule } from 'ng-otp-input';
import { OffersComponent } from './offers/offers.component';
import { HttpClientModule } from '@angular/common/http';
import { BaidyanathComponent } from './categories/baidyanath/baidyanath.component';


import  firebase from '.././../node_modules/firebase/compat/app';
// import '../../node_modules/firebase/compat/auth';
// import '../../node_modules/firebase/compat/firestore';
 //import * as firebase from 'firebase';
// import * as firebase '.././node_modules/firebase/compat/firestore'
//import * as firebase from  '../../node_modules/firebase/compat';
import { CategoryService } from './services/category.service';

import { CovidEssentialComponent } from './categories/covid-essential/covid-essential.component';
import { PpeKitComponent } from './categories/covid-essential/ppe-kit/ppe-kit.component';
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
const firebaseConfig = {
  apiKey: "AIzaSyAOJj7knhfEPX-Ux52xUrLfs0KThUTOcXs",
  authDomain: "pharmeasy-f4ffe.firebaseapp.com",
  projectId: "pharmeasy-f4ffe",
  storageBucket: "pharmeasy-f4ffe.appspot.com",
  messagingSenderId: "740336809372",
  appId: "1:740336809372:web:0d5395410191cd3702c459",
  measurementId: "G-YNQW4GYJQV"
};
firebase.initializeApp(firebaseConfig);
// const app = initializeApp(firebaseConfig);
// const analytics = getAnalytics(app);
// const auth = firebase.default.auth();
// const database = firebase.default.database();
@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    HeaderComponent,
    BodyComponent,
    LoginComponent,
    DashboardComponent,
    CartComponent,
    CategoriesComponent,
    PostComponent,
    UsersComponent,
    OffersComponent,
    BaidyanathComponent,
    CovidEssentialComponent,
    PpeKitComponent,
    PersonalCareComponent,
    HealthFoodDriksComponent,
    BeautyComponent,
    SkinCareComponent,
    HomeCareComponent,
    AyurvedicCareComponent,
    SexualWellnessComponent,
    FitnessSupplementsComponent,
    MotherAndBabyCareComponent,
    HealthCareDevicesComponent,
    HealthConditionComponent,
    DiabeticCareComponent,
    ElderlyCareComponent,
    AccessoriesAndWearablesComponent,
    TopProductsComponent
  
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'serverApp' }),
    AppRoutingModule,
    FormsModule,
    NgOtpInputModule,
    HttpClientModule
  ],
  providers: [CategoryService],
  bootstrap: [AppComponent]
})
export class AppModule { }
// function initializeApp(firebaseConfig: { apiKey: string; authDomain: string; projectId: string; storageBucket: string; messagingSenderId: string; appId: string; measurementId: string; }) {
//   throw new Error('Function not implemented.');
// }

// function getAnalytics(app: void) {
//   throw new Error('Function not implemented.');
// }

