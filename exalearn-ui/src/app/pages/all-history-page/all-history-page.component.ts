import { Component } from '@angular/core';
import { Location } from '@angular/common';

@Component({
	selector: 'app-all-history-page',
	templateUrl: './all-history-page.component.html',
	styleUrls: ['./all-history-page.component.scss']
})
export class AllHistoryPageComponent {
	goBack(): void {
		this.location.back();
	}
	tableColumns = ['user', 'level', 'date', 'view test'];
	dataType = 'test';
	constructor(private location: Location) {}
}
