import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { questions } from '../../test-data/test-questions';
import { Question } from '../../interfaces/interfaces';
import { TranslateService } from '@ngx-translate/core';

@Component({
	selector: 'app-test-page',
	templateUrl: './test-page.component.html',
	styleUrls: ['./test-page.component.scss']
})
export class TestPageComponent implements OnInit {
	testQuestions: Question[] = [];
	innerText = 'TIME LEFT';
	mode = 'sticky';

	constructor(public translateService: TranslateService) {}

	ngOnInit() {
		this.testQuestions = questions;
	}
	@ViewChild('timer', { read: ElementRef })
	sampleTimer: ElementRef;

	ngAfterViewInit(): void {
		this.sampleTimer.nativeElement.children[0].classList.add(this.mode);
	}
}
