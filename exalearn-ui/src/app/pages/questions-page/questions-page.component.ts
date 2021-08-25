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
	questionTest = true;
	questionTestType = true;
	tableColumns = ['questionText', 'level', 'viewQuestion'];
	tableColumnsTopic = ['questionText', 'viewQuestion'];
	levelTypes = new Array(6);
	questionTypes = new Array(3);
	currentIndex = 1;
	levelType = 1;
	questionType = 1;

	constructor(public apiService: ApiService, public userService: UserService) {}

	ngOnInit(): void {
		this.getQuestions(1, 1);
	}

	setLevel(level: number): void {
		this.levelType = level;
		this.getQuestions(level, this.questionType);
	}

	setQuestion(questionType: number): void {
		this.questionType = questionType;
		this.getQuestions(this.levelType, questionType);
	}

	getQuestions(level: number, questionType: number): void {
		this.apiService.getRequest(`${API_PATH.GET_ALL_QUESTIONS}/${level}/${questionType}`).then((data) => {
			this.data = data.map((el: any) => {
				el.questionText = el.text;
				el.level = Object.keys(EnglishLevels)[el.levelType - 1];
				return el;
			});
			this.isDataAvailable = true;
		});
	}
}
