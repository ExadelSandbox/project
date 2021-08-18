import { Component } from '@angular/core';
import { CheckCoachTest } from '../../interfaces/interfaces';
import { UserService } from '../../services/user.service';
import { ApiService } from '../../services/api.service';
import { API_PATH } from '../../constants/api.constants';
import { EnglishLevels } from '../../enums/enums';

@Component({
	selector: 'app-check-test-page',
	templateUrl: './check-test-page.component.html',
	styleUrls: ['./check-test-page.component.scss']
})
export class CheckTestPageComponent {
	isDataAvailable = false;
	tableColumns = ['level', 'date', 'check'];
	data: CheckCoachTest;

	constructor(private user: UserService, private apiService: ApiService) {}

	ngOnInit() {
		this.apiService.getRequest(API_PATH.GET_UNCHECKED_TEST).then((data) => {
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
			this.data = data;
			this.isDataAvailable = true;
		});
	}
}
