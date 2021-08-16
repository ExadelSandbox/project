import { Component, Input, OnInit } from '@angular/core';

import { CheckQuestion } from 'src/app/interfaces/interfaces';
import { checkQuestions } from '../../test-data/test-questions';

@Component({
	selector: 'app-check-audition',
	templateUrl: './check-audition.component.html',
	styleUrls: ['./check-audition.component.scss']
})
export class CheckAuditionComponent implements OnInit {
	@Input() checkQuestions: CheckQuestion[];
	currentIndex = 0;
	testQuestions: CheckQuestion[] = [];

	ngOnInit(): void {
		this.testQuestions = checkQuestions;
	}
}
