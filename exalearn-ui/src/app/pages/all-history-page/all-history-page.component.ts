import { Component } from '@angular/core';
@Component({
	selector: 'app-all-history-page',
	templateUrl: './all-history-page.component.html',
	styleUrls: ['./all-history-page.component.scss']
})
export class AllHistoryPageComponent {
	btnClicked = false;

	tableColumns = ['username', 'level', 'date', 'view test'];
	dataType = 'all-tests';
}
