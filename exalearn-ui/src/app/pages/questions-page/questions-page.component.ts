import { Component, OnInit } from '@angular/core';
import { ApiService } from '../../services/api.service';
import { UserService } from '../../services/user.service';
import { EnglishLevels } from '../../enums/enums';
import { API_PATH } from '../../constants/api.constants';

@Component({
	selector: 'app-questions-page',
	templateUrl: './questions-page.component.html',
	styleUrls: ['./questions-page.component.scss']
})
export class QuestionsPageComponent implements OnInit {
	data: any;
	isDataAvailable = false;
	tableColumns = ['questionText', 'level', 'viewQuestion'];

	constructor(public apiService: ApiService, public userService: UserService) {}

	ngOnInit(): void {
		this.apiService.getRequest(`${API_PATH.GET_ALL_QUESTIONS}/3/1`).then((data) => {
			this.data = data.map((el: any) => {
				el.questionText = el.text;
				el.level = Object.keys(EnglishLevels)[el.levelType - 1];
				return el;
			});
			this.isDataAvailable = true;
		});
	}
}
