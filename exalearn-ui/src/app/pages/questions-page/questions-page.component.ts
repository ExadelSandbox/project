import { Component, OnInit } from '@angular/core';
import { ApiService } from '../../services/api.service';
import { UserService } from '../../services/user.service';
import { MY_QUESTIONS } from '../../test-data/tables-mock-data';
import { EnglishLevels } from '../../enums/enums';

@Component({
	selector: 'app-questions-page',
	templateUrl: './questions-page.component.html',
	styleUrls: ['./questions-page.component.scss']
})
export class QuestionsPageComponent implements OnInit {
	data: any;
	isDataAvailable = false;
	tableColumns = ['question', 'level', 'viewQuestion'];

	constructor(public apiService: ApiService, public userService: UserService) {}

	ngOnInit(): void {
		this.data = MY_QUESTIONS;
		this.data.forEach((el: any) => {
			el.level = Object.keys(EnglishLevels)[el.levelType - 1];
			delete el.levelType;
		});
		this.isDataAvailable = true;
	}
}
