import { Component, OnInit } from '@angular/core';
import { UserService } from '../../services/user.service';
import { ApiService } from '../../services/api.service';
import { MyAssigned } from '../../interfaces/interfaces';
import { EnglishLevels } from '../../enums/enums';
import { API_PATH } from '../../constants/api.constants';

@Component({
	selector: 'app-my-assigned-tests-page',
	templateUrl: './my-assigned-tests-page.component.html',
	styleUrls: ['./my-assigned-tests-page.component.scss']
})
export class MyAssignedTestsPageComponent implements OnInit {
	isDataAvailable = false;
	tableColumns = ['level', 'expire', 'assigned by', 'start'];
	data: MyAssigned;

	constructor(private userService: UserService, private apiService: ApiService) {}

	ngOnInit() {
		this.apiService
			.getRequest(API_PATH.MY_ASSIGNED_TESTS, { id: this.userService.currentUser?.currentUserId })
			.then((data) => {
				data.forEach((element: any) => {
					element.level = Object.keys(EnglishLevels)[element.level - 1];
				});
				this.data = data;
				this.isDataAvailable = true;
			});
	}
}
