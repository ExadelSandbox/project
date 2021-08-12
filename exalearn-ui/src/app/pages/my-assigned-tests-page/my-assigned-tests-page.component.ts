import { Component, OnInit } from '@angular/core';
import { UserService } from '../../services/user.service';
import { ApiService } from '../../services/api.service';
import { MyAssigned } from '../../interfaces/interfaces';
import { EnglishLevels } from '../../enums/enums';

@Component({
	selector: 'app-my-assigned-tests-page',
	templateUrl: './my-assigned-tests-page.component.html',
	styleUrls: ['./my-assigned-tests-page.component.scss']
})
export class MyAssignedTestsPageComponent implements OnInit {
	isDataAvailable = false;
	tableColumns = ['level', 'expire', 'assigned by', 'start'];
	currentUser: any;
	data: MyAssigned;

	constructor(private user: UserService, private apiService: ApiService) {}

	async ngOnInit() {
		this.currentUser = this.user.currentUser;
		this.data = await this.apiService
			.getRequest(`/api/users/${this.currentUser.id}/userAssignedTest`)
			.then((data) => {
				data.forEach((element: any) => {
					element.level = Object.values(EnglishLevels)[element.level - 1];
				});
				return data;
			});
		this.isDataAvailable = true;
	}
}
