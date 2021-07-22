import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainPageComponent } from './main-page.component';
import { MainGuard } from '../../guards/main.guard';
import { AssignTestPageComponent } from '../assign-test-page/assign-test-page.component';
import { TestPageComponent } from '../test-page/test-page.component';
import { AllHistoryPageComponent } from '../all-history-page/all-history-page.component';

const routes: Routes = [
	{
		path: '',
		component: MainPageComponent,
		canActivate: [MainGuard],
		children: [
			{
				path: 'main',
				component: MainPageComponent
			},
			{
				path: 'test',
				component: TestPageComponent
			},
			{
				path: 'assign',
				component: AssignTestPageComponent
			},
			{
				path: 'all-history',
				component: AllHistoryPageComponent
			}
		]
	}
];

@NgModule({
	imports: [RouterModule.forChild(routes)],
	exports: [RouterModule]
})
export class MainPageRouterModule {}
