import { Component, Input, OnInit } from '@angular/core';
import { Question } from '../../interfaces/interfaces';

@Component({
	selector: 'app-test-nav-btn',
	templateUrl: './test-nav-btn.component.html',
	styleUrls: ['./test-nav-btn.component.scss']
})
export class TestNavBtnComponent implements OnInit {
	// @ts-ignore
	@Input() question: Question;
	// @ts-ignore
	@Input() index: number;
	// @ts-ignore
	@Input() currentIndex: number;
	ngOnInit(): void {
		this.question.index = this.index;
	}
}
