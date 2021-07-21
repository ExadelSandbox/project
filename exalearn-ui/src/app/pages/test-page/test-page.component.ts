import { Component, OnInit } from '@angular/core';
import { questions } from '../../test-data/test-questions';
// import { Question } from '../../interfaces/interfaces';
import { Question } from '../../interfaces/question.interface';
import { TestsService } from '../../services/tests.service';

@Component({
	selector: 'app-test-page',
	templateUrl: './test-page.component.html',
	styleUrls: ['./test-page.component.scss'],
	providers: [TestsService]
})
export class TestPageComponent implements OnInit {
	// testQuestions: Question[] = [];
	level: string = 'beginner';
	grammarQuestions: Question[];
	listeningQuestions: Question;
	essayQuestion: Question;
	speakingQuestion: Question;

	constructor(private testsService: TestsService) {}

	ngOnInit() {
		// this.testQuestions = questions;
		this.grammarQuestions = this.testsService.getGrammarQuestions(this.level);
		this.listeningQuestions = this.testsService.getListeningQuestions(this.level);
		this.essayQuestion = this.testsService.getEssayQuestion(this.level);
		this.speakingQuestion = this.testsService.getSpeakingQuestion(this.level);

		console.log(this.grammarQuestions);
		console.log(this.listeningQuestions);
		console.log(this.essayQuestion);
		console.log(this.speakingQuestion);
	}
}
