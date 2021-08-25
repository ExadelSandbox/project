import { Component, Input, OnInit } from '@angular/core';
import SubmitTestService from '../../services/submit-test.service';
import { testAnswer, Topic } from '../../interfaces/interfaces';
import { ReportQuestionModalComponent } from '../report-question-modal/report-question-modal.component';
import { MatDialog } from '@angular/material/dialog';

@Component({
	selector: 'app-essay-part',
	templateUrl: './essay-part.component.html',
	styleUrls: ['./essay-part.component.scss']
})
export class EssayPartComponent implements OnInit {
	@Input() questionsEssay: any;
	@Input() testPassedId: number;

	themeEssay: Topic;
	fillingEssay = 512;
	textEssay: string;
	public isDataAvailable: boolean;
	public reportedMessage: string | null = null;

	constructor(public submit: SubmitTestService, public dialog: MatDialog) {}

	ngOnInit(): void {
		if (this.questionsEssay.length === 0) {
			this.isDataAvailable = false;
		} else {
			this.themeEssay = this.questionsEssay;
			this.isDataAvailable = true;
		}
	}

	inputHandler(value: string) {
		this.textEssay = value;
		const essayAnswer: testAnswer = {
			id: 0,
			passedTestId: this.testPassedId,
			questionId: this.themeEssay.id,
			reportedMessage: this.reportedMessage,
			userAnswer: this.textEssay,
			assessment: 0
		};
		this.submit.addData('essay', essayAnswer);
	}
	openReportDialog(): void {
		const dialogRef = this.dialog.open(ReportQuestionModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: {
				passedTestId: this.testPassedId,
				questionId: this.themeEssay.id,
				topicType: 'essay'
			}
		});
		dialogRef.afterClosed().subscribe((message) => {
			this.reportedMessage = message;
		});
	}
}
