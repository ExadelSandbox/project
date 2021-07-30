import { Component } from '@angular/core';
import { MY_ASSIGNMENTS_DATA } from '../../test-data/tables-mock-data';

@Component({
	selector: 'app-tests-assigned-by-user',
	templateUrl: './tests-assigned-by-user.component.html',
	styleUrls: ['./tests-assigned-by-user.component.scss']
})
export class TestsAssignedByUserComponent {
	data = MY_ASSIGNMENTS_DATA;
	isDataAvailable = true;
	tableColumns = ['username', 'level', 'expire', 'passed'];
}
