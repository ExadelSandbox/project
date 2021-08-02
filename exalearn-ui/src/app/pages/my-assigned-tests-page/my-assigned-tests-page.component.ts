import { Component } from '@angular/core';
import { MY_ASSIGNED_DATA } from '../../test-data/tables-mock-data';

@Component({
	selector: 'app-my-assigned-tests-page',
	templateUrl: './my-assigned-tests-page.component.html',
	styleUrls: ['./my-assigned-tests-page.component.scss']
})
export class MyAssignedTestsPageComponent {
	data = MY_ASSIGNED_DATA;
	isDataAvailable = true;
	tableColumns = ['level', 'expire', 'assigned by', 'start'];
}
