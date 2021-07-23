import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainPageComponent } from '../../pages/main-page/main-page.component';
import { LoginPageComponent } from '../../pages/login-page/login-page.component';
import { AuthGuard } from '../../guards/auth.guard';
import { MainGuard } from '../../guards/main.guard';
import { MainPageRoute } from './router-const';

const routes: Routes = [
	{
		path: '',
		redirectTo: '/main',
		pathMatch: 'full'
	},
	{
		path: 'login',
		component: LoginPageComponent,
		canActivate: [AuthGuard]
	},
	{
		path: '',
		component: MainPageComponent,
		canActivate: [MainGuard],
		children: [MainPageRoute]
	}
];

@NgModule({
	imports: [RouterModule.forRoot(routes)],
	exports: [RouterModule]
})
export class AppRoutingModule {}
