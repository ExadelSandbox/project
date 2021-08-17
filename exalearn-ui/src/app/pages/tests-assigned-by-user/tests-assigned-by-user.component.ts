import { Component } from '@angular/core';
import { API_PATH } from '../../constants/api.constants';
import { EnglishLevels } from '../../enums/enums';
import { Assignment } from '../../interfaces/interfaces';
import { ApiService } from '../../services/api.service';
import { UserService } from '../../services/user.service';

@Component({
	selector: 'app-tests-assigned-by-user',
	templateUrl: './tests-assigned-by-user.component.html',
	styleUrls: ['./tests-assigned-by-user.component.scss']
})
export class TestsAssignedByUserComponent {
	data: Assignment[];
	isDataAvailable = false;
	tableColumns = ['username', 'level', 'expire', 'passed'];

	constructor(public apiService: ApiService, public userService: UserService) {}

	ngOnInit() {
		this.apiService.getRequest(API_PATH.ALL_ASSIGNED_TEST).then((data) => {
			data.forEach((el: any) => {
				el.level = Object.keys(EnglishLevels)[el.level - 1];
				el.expire = new Date(el.expireDate);
				el.passed = el.passed ? 'Passed' : 'Not passed';
				delete el.expireDate;
			});
			this.data = data;
			this.isDataAvailable = true;
		});
	}
}
