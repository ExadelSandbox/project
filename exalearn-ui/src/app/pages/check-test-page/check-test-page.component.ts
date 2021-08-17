import { Component } from '@angular/core';
import { CheckCoachTest } from '../../interfaces/interfaces';
import { UserService } from '../../services/user.service';
import { ApiService } from '../../services/api.service';
import { API_PATH } from '../../constants/api.constants';

@Component({
	selector: 'app-check-test-page',
	templateUrl: './check-test-page.component.html',
	styleUrls: ['./check-test-page.component.scss']
})
export class CheckTestPageComponent {
	isDataAvailable = false;
	tableColumns = ['level', 'expire', 'check'];
	currentUser: any;
	data: CheckCoachTest;

	constructor(private user: UserService, private apiService: ApiService) {}

	async ngOnInit() {
		this.currentUser = this.user.currentUser;
		this.data = await this.apiService.getRequest(API_PATH.GET_UNCHECKED_TEST).then(() => {
			console.log(this.data);
			return this.data;
		});
		this.isDataAvailable = true;
	}
}
