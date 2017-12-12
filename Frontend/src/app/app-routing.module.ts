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
