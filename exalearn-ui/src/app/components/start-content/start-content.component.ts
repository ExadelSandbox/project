import { Component } from '@angular/core';
import { UserService } from '../../services/user.service';
import { EnglishLevels } from '../../enums/enums';
import { API_PATH } from '../../constants/api.constants';
import { ApiService } from '../../services/api.service';

@Component({
	selector: 'app-start-content',
	templateUrl: './start-content.component.html',
	styleUrls: ['./start-content.component.scss']
})
export class StartContentComponent {
	userName: string;
	userLevel: EnglishLevels | null;
	assignNumber: number;

	constructor(public userService: UserService, public apiService: ApiService) {}
	ngOnInit() {
		if (this.userService.currentUser) {
			this.userName = this.userService.currentUser.fullName;
			this.userLevel = this.userService.currentUser.level;
		}
		this.apiService
			.getRequest(API_PATH.MY_ASSIGNED_TESTS, { id: this.userService.currentUser?.currentUserId })
			.then((data) => {
				this.assignNumber = data.length;
			});
	}
}
