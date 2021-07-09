import { NgModule } from '@angular/core';
import {RouterModule, Routes} from "@angular/router";
import {MainPageComponent} from "../../Pages/main-page/main-page.component";

const routes: Routes = [
  { path: 'main-page', component: MainPageComponent },
  { path: '', redirectTo: '/main-page', pathMatch: 'full' },
  { path: 'history-page', component: MainPageComponent },
  { path: 'test-page', component: MainPageComponent },
  { path: 'assigned-tests-page', component: MainPageComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
