import { Component, Input, OnInit } from '@angular/core';

import { CheckCoachQuestion, CheckQuestion } from '../../interfaces/interfaces';

@Component({
	selector: 'app-check-nav-btn',
	templateUrl: './check-nav-btn.component.html',
	styleUrls: ['./check-nav-btn.component.scss']
})
export class CheckNavBtnComponent implements OnInit {
	@Input() answer: CheckCoachQuestion;
	@Input() index: number;
	@Input() currentIndex: number;
	@Input() questionId: number;

	ngOnInit(): void {
		// this.question.index = this.index;
	}
}
