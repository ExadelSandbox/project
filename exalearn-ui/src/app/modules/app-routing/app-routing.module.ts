import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TestPageComponent } from '../../pages/test-page/test-page.component';
import { AssignTestPageComponent } from '../../pages/assign-test-page/assign-test-page.component';
import { MainPageLayoutComponent } from '../../layouts/main-page-layout/main-page-layout.component';
import { LoginPageLayoutComponent } from '../../layouts/login-page-layout/login-page-layout.component';

const routes: Routes = [
	{ path: '', redirectTo: '/login', pathMatch: 'full' },
	{ path: 'assign', component: AssignTestPageComponent },
	//{ path: '**', redirectTo: '/main', pathMatch: 'full' },
	{ path: 'test', component: TestPageComponent },
	{
		path: '',
		component: LoginPageLayoutComponent,
		children: [
			{
				path: '',
				redirectTo: '/login-page',
				pathMatch: 'full'
			},
			{
				path: 'login-page',
				loadChildren: () => import('src/app/pages/login-page/login-page.module').then((m) => m.LoginPageModule)
			}
		]
	},
	{
		path: '',
		component: MainPageLayoutComponent,
		children: [
			{
				path: '',
				redirectTo: '/main-page',
				pathMatch: 'full'
			},
			{
				path: 'main-page',
				loadChildren: () => import('src/app/pages/main-page/main-page.module').then((m) => m.MainPageModule)
			}
		]
	}
];

@NgModule({
	imports: [RouterModule.forRoot(routes)],
	exports: [RouterModule]
})
export class AppRoutingModule {}
