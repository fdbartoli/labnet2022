import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { SuppliersComponent } from './suppliers/suppliers.component';
import { HeaderComponent } from './header/header.component';
import { SuppliersFormsComponent } from './suppliers-forms/suppliers-forms.component';

const routes: Routes = [
  { path: '', component: SuppliersComponent },
  { path: 'home', component: HomeComponent },
  { path: 'suppliersform', component: SuppliersFormsComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
