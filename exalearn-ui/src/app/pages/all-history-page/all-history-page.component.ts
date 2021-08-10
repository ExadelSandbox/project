import { Component, OnInit } from '@angular/core';
import { ALL_TESTS_DATA } from '../../test-data/tables-mock-data';
import { API_PATH } from '../../constants/api.constants';
import { ApiService } from '../../services/api.service';
import { PassedTest } from '../../interfaces/interfaces';
@Component({
	selector: 'app-all-history-page',
	templateUrl: './all-history-page.component.html',
	styleUrls: ['./all-history-page.component.scss']
})
export class AllHistoryPageComponent implements OnInit {
	// data = ALL_TESTS_DATA;
	data: PassedTest[] = [];
	isDataAvailable = false;
	tableColumns = ['username', 'level', 'date', 'view test'];
	constructor(public apiService: ApiService) {}
	ngOnInit() {
		this.apiService.getRequest(API_PATH.HISTORY).then((data) => {
			console.log(data);
			this.data = data;
			this.isDataAvailable = true;
		});
	}
}
