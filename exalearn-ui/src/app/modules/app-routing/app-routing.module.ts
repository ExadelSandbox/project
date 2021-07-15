import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainPageComponent } from '../../pages/main-page/main-page.component';
import { LoginPageComponent } from '../../pages/login-page/login-page.component';

const routes: Routes = [
	{ path: 'main', component: MainPageComponent },
	{ path: '', redirectTo: '/login', pathMatch: 'full' },
	{ path: 'login', component: LoginPageComponent }
];

@NgModule({
	imports: [RouterModule.forRoot(routes)],
	exports: [RouterModule]
})
export class AppRoutingModule {}
