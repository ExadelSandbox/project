import { Component } from '@angular/core';

@Component({
	selector: 'app-check-test-page',
	templateUrl: './check-test-page.component.html',
	styleUrls: ['./check-test-page.component.scss']
})
export class CheckTestPageComponent {
	tableColumns = ['level', 'date', 'view test'];
	dataType = 'my-tests';
}
