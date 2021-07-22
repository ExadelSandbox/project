import { Component, OnInit } from '@angular/core';
import { environment } from '../../../environments/environment';
import { TranslateService } from '@ngx-translate/core';
import { Question } from '../../interfaces/question.interface';
import { TestsService } from '../../services/tests.service';
import { EnglishLevels } from '../../enums/enums';

@Component({
	selector: 'app-test-page',
	templateUrl: './test-page.component.html',
	styleUrls: ['./test-page.component.scss'],
	providers: [TestsService]
})
export class TestPageComponent implements OnInit {
	level: string = EnglishLevels.B1;
	grammarQuestions: Question[];
	listeningQuestions: Question;
	essayQuestion: Question;
	speakingQuestion: Question;

	constructor(public translateService: TranslateService, private testsService: TestsService) {}

	ngOnInit() {
		this.grammarQuestions = this.testsService.getGrammarQuestions(this.level);
		this.listeningQuestions = this.testsService.getListeningQuestions(this.level);
		this.essayQuestion = this.testsService.getEssayQuestion(this.level);
		this.speakingQuestion = this.testsService.getSpeakingQuestion(this.level);

		//TODO use user state from backend. For the test, because then we will accept the user's language from the backend.
		//TODO When the page is reloaded, the state is cleared and we have no language
		this.translateService.use(environment.defaultLocale);
	}
}
