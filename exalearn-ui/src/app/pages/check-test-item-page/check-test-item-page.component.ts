import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ApiService } from '../../services/api.service';
import { API_PATH } from '../../constants/api.constants';
import { CheckCoach, CheckCoachQuestion } from '../../interfaces/interfaces';

@Component({
	selector: 'app-check-test-item-page',
	templateUrl: './check-test-item-page.component.html',
	styleUrls: ['./check-test-item-page.component.scss']
})
export class CheckTestItemPageComponent implements OnInit {
	passedTestId: number;
	dataCheckTest: any;
	data: CheckCoach;

	public testGrammar: CheckCoachQuestion[] = [];
	public testAudition: CheckCoachQuestion[] = [];
	public testTopic: CheckCoachQuestion[] = [];

	constructor(private router: Router, private apiService: ApiService) {
		//this.passedTestId = this?.router?.getCurrentNavigation()?.extras?.state?.data.id;
		this.passedTestId = 1;
	}

	ngOnInit() {
		this.apiService.getRequest(API_PATH.GET_CHECK_TEST + `${this.passedTestId}`).then((data) => {
			data.userAnswers.forEach((el: any) => {
				el.questionText = el.question.questionText;
				switch (el.question.questionType) {
					case 1:
						this.getCheckQuestionGrammar(el);
						break;
					case 2:
						this.getCheckQuestionAudition(el);
						break;
					case 3:
						this.getCheckQuestionTopic(el);
						break;
				}
			});
		});
	}

	getCheckQuestionGrammar(item: any): void {
		item.answers = [];
		item.question.choices.forEach((answer: any) => {
			item.answers.push(answer);
			if (answer.isCorrect) {
				item.rightAnswer = answer;
			}
		});
		this.testGrammar.push(item);
		delete item.question;
	}

	getCheckQuestionAudition(item: any): void {
		item.answers = [];
		item.question.choices.forEach((answer: any) => {
			item.answers.push(answer);
			if (answer.isCorrect) {
				item.rightAnswer = answer;
			}
		});
		this.testAudition.push(item);
		delete item.question;
	}

	getCheckQuestionTopic(item: any): void {
		item.answers = [];
		item.question.choices.forEach((answer: any) => {
			item.answers.push(answer);
			if (answer.isCorrect) {
				item.rightAnswer = answer;
			}
		});
		this.testTopic.push(item);
		delete item.question;
	}
}
