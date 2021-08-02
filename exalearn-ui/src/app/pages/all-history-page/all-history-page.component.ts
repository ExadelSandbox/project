import { Component } from '@angular/core';
import { ALL_TESTS_DATA } from '../../test-data/tables-mock-data';
@Component({
	selector: 'app-all-history-page',
	templateUrl: './all-history-page.component.html',
	styleUrls: ['./all-history-page.component.scss']
})
export class AllHistoryPageComponent {
	data = ALL_TESTS_DATA;
	isDataAvailable = true;
	tableColumns = ['username', 'level', 'date', 'view test'];
}
