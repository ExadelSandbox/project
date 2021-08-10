import { Component, OnInit } from '@angular/core';
import { MY_TESTS_DATA } from '../../test-data/tables-mock-data';
import { API_PATH } from '../../constants/api.constants';
import { ApiService } from '../../services/api.service';
import { UserService } from '../../services/user.service';
import { PassedTest } from '../../interfaces/interfaces';

@Component({
	selector: 'app-my-history-page',
	templateUrl: './my-history-page.component.html',
	styleUrls: ['./my-history-page.component.scss']
})
export class MyHistoryPageComponent implements OnInit {
	// data = MY_TESTS_DATA;
	data: PassedTest[] = [];
	isDataAvailable = false;
	tableColumns = ['level', 'date', 'totalScore'];
	constructor(public apiService: ApiService, public userService: UserService) {}
	ngOnInit() {
		this.apiService
			.getRequest(API_PATH.USER_HISTORY, { id: this.userService.currentUser?.currentUserId })
			.then((data) => {
				console.log(data);
				// const tests: PassedTest[] = [];
				// for (const test of data) {
				//   tests.push({
				//
				//   })
				// }
				this.data = data;
				this.isDataAvailable = true;
			});
	}
}
