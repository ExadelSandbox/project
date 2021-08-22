import { Component, DoCheck, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { ApiService } from '../../services/api.service';
import { API_PATH } from '../../constants/api.constants';
import { CheckCoach, CheckCoachQuestion } from '../../interfaces/interfaces';
import { CheckEssayComponent } from '../../components/check-essay/check-essay.component';
import { CheckSpeakingComponent } from '../../components/check-speaking/check-speaking.component';

@Component({
	selector: 'app-check-test-item-page',
	templateUrl: './check-test-item-page.component.html',
	styleUrls: ['./check-test-item-page.component.scss']
})
export class CheckTestItemPageComponent implements OnInit, DoCheck {
	@ViewChild(CheckEssayComponent, { static: false })
	public checkEssayComponent: CheckEssayComponent | undefined;

	@ViewChild(CheckSpeakingComponent, { static: false })
	public checkSpeakingComponent: CheckSpeakingComponent | undefined;

	passedTestId: number;
	data: CheckCoach;
	public isDataAvailable: boolean;

	essayMark: number | undefined;
	speakingMark: number | undefined;

	public testGrammarAnswers: CheckCoachQuestion[] = [];
	public testAuditionAnswers: CheckCoachQuestion[] = [];
	public testTopicAnswers: CheckCoachQuestion[] = [];
	public currentTab: string;

	constructor(private router: Router, private apiService: ApiService) {
		this.passedTestId = this?.router?.getCurrentNavigation()?.extras?.state?.data.id;
	}

	ngOnInit() {
		this.apiService
			.getRequest(API_PATH.GET_CHECK_TEST + `${this.passedTestId}`)
			.then((data) => {
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
				this.isDataAvailable = false;
			})
			.then(() => {
				this.isDataAvailable = true;
			});
	}

	ngDoCheck() {
		this.essayMark = this.checkEssayComponent?.essayMark;
		this.speakingMark = this.checkSpeakingComponent?.speakingMark;
	}

	setTabName(event: any) {
		this.currentTab = event.tab.textLabel;
	}

	getCheckQuestionGrammar(item: any): void {
		item.answers = [];
		item.question.choices.forEach((answer: any) => {
			item.answers.push(answer);
			if (answer.isCorrect) {
				item.rightAnswer = answer;
			}
		});
		this.testGrammarAnswers.push(item);
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
		this.testAuditionAnswers.push(item);
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
		this.testTopicAnswers.push(item);
		delete item.question;
	}
}
