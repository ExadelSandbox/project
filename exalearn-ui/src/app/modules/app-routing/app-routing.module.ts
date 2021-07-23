import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainPageComponent } from '../../pages/main-page/main-page.component';
import { LoginPageComponent } from '../../pages/login-page/login-page.component';
import { AuthGuard } from '../../guards/auth.guard';
import { MainGuard } from '../../guards/main.guard';
import { TestPageComponent } from '../../pages/test-page/test-page.component';
import { AssignTestPageComponent } from '../../pages/assign-test-page/assign-test-page.component';
import { AllHistoryPageComponent } from '../../pages/all-history-page/all-history-page.component';
import { MyHistoryPageComponent } from '../../pages/my-history-page/my-history-page.component';
import { MyAssignedTestsPageComponent } from '../../pages/my-assigned-tests-page/my-assigned-tests-page.component';
import { CreatePageComponent } from '../../pages/create-page/create-page.component';
import { TestsAssignedByUserComponent } from '../../pages/tests-assigned-by-user/tests-assigned-by-user.component';

const routes: Routes = [
	{ path: 'main', component: MainPageComponent, canActivate: [MainGuard] },
	{ path: '', redirectTo: '/login', pathMatch: 'full' },
	{ path: 'login', component: LoginPageComponent, canActivate: [AuthGuard] },
	{ path: 'test', component: TestPageComponent },
	{ path: 'assign', component: AssignTestPageComponent },
	{ path: 'all-history', component: AllHistoryPageComponent },
	{ path: 'my-history', component: MyHistoryPageComponent },
	{ path: 'my-assigned-tests', component: MyAssignedTestsPageComponent },
	{ path: 'all-assigned', component: TestsAssignedByUserComponent },
	{ path: 'create', component: CreatePageComponent }
];

@NgModule({
	imports: [RouterModule.forRoot(routes)],
	exports: [RouterModule]
})
export class AppRoutingModule {}
