import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainPageComponent } from '../../pages/main-page/main-page.component';
import { TestPageComponent } from '../../pages/test-page/test-page.component';

const routes: Routes = [
	{ path: 'main', component: MainPageComponent },
	{ path: '', redirectTo: '/main', pathMatch: 'full' },
	{ path: 'test', component: TestPageComponent }
];

@NgModule({
	imports: [RouterModule.forRoot(routes)],
	exports: [RouterModule]
})
export class AppRoutingModule {}
