import { StartContentComponent } from '../../components/start-content/start-content.component';
import { AssignTestPageComponent } from '../../pages/assign-test-page/assign-test-page.component';
import { AllHistoryPageComponent } from '../../pages/all-history-page/all-history-page.component';
import { MyHistoryPageComponent } from '../../pages/my-history-page/my-history-page.component';
import { MyAssignedTestsPageComponent } from '../../pages/my-assigned-tests-page/my-assigned-tests-page.component';
import { CreatePageComponent } from '../../pages/create-page/create-page.component';
import { TestsAssignedByUserComponent } from '../../pages/tests-assigned-by-user/tests-assigned-by-user.component';
import { CheckTestPageComponent } from '../../pages/check-test-page/check-test-page.component';
import { CheckTestItemPageComponent } from '../../pages/check-test-item-page/check-test-item-page.component';
import { RoleHRGuard } from '../../guards/role-hr.guard';
import { RoleCoachGuard } from '../../guards/role-coach.guard';
import { QuestionsPageComponent } from '../../pages/questions-page/questions-page.component';

export const MainPageRoute = {
	path: '',
	children: [
		{
			path: 'main',
			component: StartContentComponent
		},
		{
			path: 'assign',
			component: AssignTestPageComponent,
			canActivate: [RoleHRGuard]
		},
		{
			path: 'all-history',
			component: AllHistoryPageComponent,
			canActivate: [RoleHRGuard]
		},
		{
			path: 'my-history',
			component: MyHistoryPageComponent
		},
		{
			path: 'my-assigned-tests',
			component: MyAssignedTestsPageComponent
		},
		{
			path: 'create',
			component: CreatePageComponent,
			canActivate: [RoleCoachGuard]
		},
		{
			path: 'all-assigned',
			component: TestsAssignedByUserComponent,
			canActivate: [RoleHRGuard]
		},
		{
			path: 'check-test-list',
			component: CheckTestPageComponent,
			canActivate: [RoleCoachGuard]
		},
		{
			path: 'check-test-item',
			component: CheckTestItemPageComponent,
			canActivate: [RoleCoachGuard]
		},
		{
			path: 'question-check',
			component: QuestionsPageComponent,
			canActivate: [RoleCoachGuard]
		}
	]
};
