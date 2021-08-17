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
	tableColumns = ['level', 'expire', 'check'];
	data: CheckCoachTest;

	constructor(private user: UserService, private apiService: ApiService) {}

	ngOnInit() {
		this.apiService.getRequest(API_PATH.GET_UNCHECKED_TEST).then((data) => {
			data.forEach((element: any) => {
				element.levelType = Object.keys(EnglishLevels)[element.levelType - 1];
			});
			this.data = data;
			this.isDataAvailable = true;
		});
	}
}
