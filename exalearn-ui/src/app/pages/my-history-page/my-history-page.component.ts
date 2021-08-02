import { Component } from '@angular/core';
import { MY_TESTS_DATA } from '../../test-data/tables-mock-data';

@Component({
	selector: 'app-my-history-page',
	templateUrl: './my-history-page.component.html',
	styleUrls: ['./my-history-page.component.scss']
})
export class MyHistoryPageComponent {
	data = MY_TESTS_DATA;
	isDataAvailable = true;
	tableColumns = ['level', 'date', 'totalScore'];
}
