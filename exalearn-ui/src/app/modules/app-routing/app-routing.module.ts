import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainPageComponent } from '../../pages/main-page/main-page.component';
import { LoginPageComponent } from '../../pages/login-page/login-page.component';
import { AuthGuard } from '../../guards/auth.guard';
import { MainGuard } from '../../guards/main.guard';
import { TestPageComponent } from '../../pages/test-page/test-page.component';
import { AssignTestPageComponent } from '../../pages/assign-test-page/assign-test-page.component';
import { AllHistoryPageComponent } from '../../pages/all-history-page/all-history-page.component';

const routes: Routes = [
	{ path: 'main', component: MainPageComponent, canActivate: [MainGuard] },
	{ path: '', redirectTo: '/login', pathMatch: 'full' },
	{ path: 'login', component: LoginPageComponent, canActivate: [AuthGuard] },
	{ path: 'test', component: TestPageComponent },
	{ path: 'assign', component: AssignTestPageComponent },
	{ path: 'all-history', component: AllHistoryPageComponent }
];

@NgModule({
	imports: [RouterModule.forRoot(routes)],
	exports: [RouterModule]
})
export class AppRoutingModule {}
