import { Component, OnInit } from '@angular/core';
import { API_PATH } from '../../constants/api.constants';
import { ApiService } from '../../services/api.service';
import { PassedTest } from '../../interfaces/interfaces';
import { EnglishLevels } from '../../enums/enums';
@Component({
	selector: 'app-all-history-page',
	templateUrl: './all-history-page.component.html',
	styleUrls: ['./all-history-page.component.scss']
})
export class AllHistoryPageComponent implements OnInit {
	data: PassedTest[] = [];
	isDataAvailable = false;
	tableColumns = ['username', 'level', 'date', 'view test'];
	constructor(public apiService: ApiService) {}
	ngOnInit() {
		this.apiService.getRequest(API_PATH.ALL_HISTORY).then((data) => {
			data.forEach((el: any) => {
				el.username = el.fullName;
				el.level = Object.keys(EnglishLevels)[el.levelType - 1];
				el.date = new Date(el.passedTestDate);
				el.totalScore = el.assessment;
				delete el.assessment;
				delete el.passedTestDate;
				delete el.levelType;
				delete el.fullName;
			});
			const tableValues: PassedTest[] = data;
			this.data = tableValues;
			this.isDataAvailable = true;
		});
	}
}
