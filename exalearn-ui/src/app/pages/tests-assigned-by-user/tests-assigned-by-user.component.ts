import { Component } from '@angular/core';

@Component({
	selector: 'app-tests-assigned-by-user',
	templateUrl: './tests-assigned-by-user.component.html',
	styleUrls: ['./tests-assigned-by-user.component.scss']
})
export class TestsAssignedByUserComponent {
	tableColumns = ['username', 'level', 'expire', 'passed'];
	dataType = 'tests-assigned-by-user';
}
