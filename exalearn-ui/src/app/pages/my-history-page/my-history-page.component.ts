import { Component } from '@angular/core';

@Component({
	selector: 'app-my-history-page',
	templateUrl: './my-history-page.component.html',
	styleUrls: ['./my-history-page.component.scss']
})
export class MyHistoryPageComponent {
	btnClicked = false;

	tableColumns = ['level', 'date', 'totalScore', 'view test'];
	dataType = 'my-tests';
}
