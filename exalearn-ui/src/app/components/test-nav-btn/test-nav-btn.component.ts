import { Component, Input, OnInit } from '@angular/core';
import { Question } from '../../interfaces/interfaces';
import SubmitTestService from '../../services/submit-test.service';

@Component({
	selector: 'app-test-nav-btn',
	templateUrl: './test-nav-btn.component.html',
	styleUrls: ['./test-nav-btn.component.scss']
})
export class TestNavBtnComponent implements OnInit {
	@Input() question: Question;
	@Input() index: number;
	@Input() currentIndex: number;
	@Input() questionId: number;

	constructor(public submit: SubmitTestService) {}

	ngOnInit(): void {
		this.question.index = this.index;
	}
}
