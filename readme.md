# BlackSholes
2017/12/12
## 專案目標
測試Black & Sholes模型
## 需要
1. 下載WebTemp5範本
1. https://github.com/PeterHsu/WebTemp5
## 建立專案目錄
建主BlackSholes目錄
```
BlackSholes>dotnet new classlib
```
## 加入參考
```
Backend>dotnet add reference ..\BlackSholes\BlackSholes.csproj
```
## Frontend
```
>npm install bootstrap@4.0.0-beta.2 --save
```
## styles.scss
```
@import "~bootstrap/scss/bootstrap";
```
## 加入component
```
ng g component blacksholes
```
## app.module.ts
```
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BlacksholesComponent } from './blacksholes/blacksholes.component';

@NgModule({
  declarations: [
    AppComponent,
    BlacksholesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
```
## app-routing.module.ts
```
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BlacksholesComponent } from './blacksholes/blacksholes.component';

const routes: Routes = [
  {path: '', redirectTo: '/blacksholes', pathMatch: 'full'},
  {path: 'blacksholes', component: BlacksholesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
```
## app.component.html
```
<div class="container">
  <router-outlet></router-outlet>
</div>
```
