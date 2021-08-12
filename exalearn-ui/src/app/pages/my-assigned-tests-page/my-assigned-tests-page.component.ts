import { Component, OnInit } from '@angular/core';
import { UserService } from '../../services/user.service';
import { ApiService } from '../../services/api.service';
import SubmitTestService from '../../services/submit-test.service';
import { MyAssigned } from '../../interfaces/interfaces';

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

	constructor(private user: UserService, private apiService: ApiService, private submitTest: SubmitTestService) {}

	async ngOnInit() {
		this.currentUser = this.user.currentUser;
		this.data = await this.apiService.getRequest(`/api/users/${this.currentUser.id}/userAssignedTest`);
		this.isDataAvailable = true;
	}
}
