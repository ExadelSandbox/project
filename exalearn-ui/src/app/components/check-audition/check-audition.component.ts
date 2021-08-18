import { Component, Input, OnInit } from '@angular/core';

import { CheckCoachQuestion, CheckQuestion } from 'src/app/interfaces/interfaces';
import { checkQuestions } from '../../test-data/test-questions';

@Component({
	selector: 'app-check-audition',
	templateUrl: './check-audition.component.html',
	styleUrls: ['./check-audition.component.scss']
})
export class CheckAuditionComponent implements OnInit {
	@Input() checkQuestions: CheckQuestion[];
	@Input() testAudition: CheckCoachQuestion[];

	currentIndex = 0;
	testQuestionsAudit: CheckQuestion[] = [];

	ngOnInit(): void {
		this.testQuestionsAudit = checkQuestions;
	}
}
