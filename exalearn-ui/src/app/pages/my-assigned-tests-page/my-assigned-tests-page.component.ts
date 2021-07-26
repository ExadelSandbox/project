import { Component } from '@angular/core';

@Component({
	selector: 'app-my-assigned-tests-page',
	templateUrl: './my-assigned-tests-page.component.html',
	styleUrls: ['./my-assigned-tests-page.component.scss']
})
export class MyAssignedTestsPageComponent {
	btnClicked = false;

	tableColumns = ['level', 'expire', 'assigned by', 'start'];
	dataType = 'my-assigned-tests';
}
