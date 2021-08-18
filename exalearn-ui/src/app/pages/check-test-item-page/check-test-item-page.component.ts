import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ApiService } from '../../services/api.service';
import { API_PATH } from '../../constants/api.constants';
import { CheckCoach } from '../../interfaces/interfaces';

@Component({
	selector: 'app-check-test-item-page',
	templateUrl: './check-test-item-page.component.html',
	styleUrls: ['./check-test-item-page.component.scss']
})
export class CheckTestItemPageComponent implements OnInit {
	passedTestId: number;
	dataCheckTest: any;
	data: CheckCoach;

	constructor(private router: Router, private apiService: ApiService) {
		//this.passedTestId = this?.router?.getCurrentNavigation()?.extras?.state?.data.id;
		this.passedTestId = 1;
	}

	ngOnInit() {
		this.apiService.getRequest(API_PATH.GET_CHECK_TEST + `${this.passedTestId}`).then((data) => {
			console.log(data);
			// this.dataCheckTest = data;
			data.userAnswers.forEach((el: any) => {
				console.log(el);
			});
			//data.forEach((el: any) => {
			//el.questionText = el.question.questionText;
			//switch (el.question.questionType) {
			//	case 1:
			//this.getCheckQuestionGrammar(el);
			//		break;
			//}
			//});
		});
	}
	//getCheckQuestionGrammar(item: any) {
	//	item.answerOption = [];
	//	item.choices.forEach((answer: any) => {
	//		item.answerOption.push(answer);
	//		if (answer.isCorrect) {
	//			item.rightAnswer = answer;
	//		}
	//	});
	//	delete item.question;
	//}
}
