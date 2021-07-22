import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainPageComponent } from './main-page.component';
import { MainGuard } from '../../guards/main.guard';

const routes: Routes = [
	{
		path: '',
		component: MainPageComponent,
		canActivate: [MainGuard],
		children: [
			{
				path: 'main',
				component: MainPageComponent
			}
		]
	}
];

@NgModule({
	imports: [RouterModule.forChild(routes)],
	exports: [RouterModule]
})
export class MainPageRouterModule {}
