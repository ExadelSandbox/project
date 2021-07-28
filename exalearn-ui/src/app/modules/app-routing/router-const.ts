import { StartContentComponent } from '../../components/start-content/start-content.component';
import { TestPageComponent } from '../../pages/test-page/test-page.component';
import { AssignTestPageComponent } from '../../pages/assign-test-page/assign-test-page.component';
import { AllHistoryPageComponent } from '../../pages/all-history-page/all-history-page.component';
import { MyHistoryPageComponent } from '../../pages/my-history-page/my-history-page.component';
import { MyAssignedTestsPageComponent } from '../../pages/my-assigned-tests-page/my-assigned-tests-page.component';
import { CreatePageComponent } from '../../pages/create-page/create-page.component';
import { TestsAssignedByUserComponent } from '../../pages/tests-assigned-by-user/tests-assigned-by-user.component';
import { CheckTestPageModule } from '../../pages/check-test-page/check-test-page.module';

export const MainPageRoute = {
	path: '',
	children: [
		{
			path: 'main',
			component: StartContentComponent
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
			component: CreatePageComponent
		},
		{
			path: 'all-assigned',
			component: TestsAssignedByUserComponent
		},
		{
			path: 'check',
			component: CheckTestPageModule
		}
	]
};
