import { Component, OnInit } from '@angular/core';
import { API_PATH } from '../../constants/api.constants';
import { ApiService } from '../../services/api.service';
import { UserService } from '../../services/user.service';
import { PassedTest } from '../../interfaces/interfaces';
import { EnglishLevels } from '../../enums/enums';

@Component({
	selector: 'app-my-history-page',
	templateUrl: './my-history-page.component.html',
	styleUrls: ['./my-history-page.component.scss']
})
export class MyHistoryPageComponent implements OnInit {
	data: PassedTest[] = [];
	isDataAvailable = false;
	tableColumns = ['level', 'date', 'totalScore'];
	constructor(public apiService: ApiService, public userService: UserService) {}
	ngOnInit() {
		this.apiService
			.getRequest(API_PATH.OWN_HISTORY, { id: this.userService.currentUser?.currentUserId })
			.then((data) => {
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
