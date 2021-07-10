import { NgModule } from '@angular/core';
import { RouterModule, Routes } from "@angular/router";
import { MainPageComponent } from "../../pages/main-page/main-page.component";

const routes: Routes = [
  { path: 'main', component: MainPageComponent },
  { path: '', redirectTo: '/main', pathMatch: 'full' },
  // { path: 'history', component: MainPageComponent },
  // { path: 'test', component: MainPageComponent },
  // { path: 'assigned', component: MainPageComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
