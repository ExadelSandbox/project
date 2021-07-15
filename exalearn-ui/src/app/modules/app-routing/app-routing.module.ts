import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainPageComponent } from '../../pages/main-page/main-page.component';
import { AuditionComponent } from '../../components/audition/audition.component';

const routes: Routes = [
	{ path: 'main', component: MainPageComponent },
	{ path: '', redirectTo: '/main', pathMatch: 'full' },
	{ path: 'audition', component: AuditionComponent }
];

@NgModule({
	imports: [RouterModule.forRoot(routes)],
	exports: [RouterModule]
})
export class AppRoutingModule {}
