import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginPageComponent } from './login-page.component';
import { AuthGuard } from '../../guards/auth.guard';

const routes: Routes = [
	{
		path: '',
		component: LoginPageComponent,
		canActivate: [AuthGuard],
		children: [
			{
				path: 'login',
				component: LoginPageComponent
			}
		]
	}
];

@NgModule({
	imports: [RouterModule.forChild(routes)],
	exports: [RouterModule]
})
export class LoginPageRouterModule {}
