import { Component, DoCheck, Input } from '@angular/core';
import { Question, testAnswer } from '../../interfaces/interfaces';
import SubmitTestService from '../../services/submit-test.service';
import { MatDialog } from '@angular/material/dialog';
import { ReportQuestionModalComponent } from '../report-question-modal/report-question-modal.component';

@Component({
	selector: 'app-question',
	templateUrl: './question.component.html',
	styleUrls: ['./question.component.scss']
})
export class QuestionComponent implements DoCheck {
	@Input() question: Question;
	@Input() testPassedId: number;
	@Input() currentIndex: number;
	public testQuestions: Question[] = [];
	public navButtons: any;
	public reportedMessage: string | null = null;
	constructor(public submit: SubmitTestService, public dialog: MatDialog) {}

	ngDoCheck() {
		this.navButtons = document.querySelectorAll('.nav-btn');
	}

	addDataHandleClick(choise: Question): void {
		const currentAnswer: testAnswer = {
			id: 0,
			passedTestId: this.testPassedId,
			questionId: this.question.id,
			reportedMessage: this.reportedMessage,
			userAnswer: choise.text,
			assessment: 0
		};
		this.navButtons[this.currentIndex].classList.add('nav-btn-completed');
		this.submit.addData(this.question.id, currentAnswer);
	}
	openReportDialog(): void {
		const dialogRef = this.dialog.open(ReportQuestionModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: {
				passedTestId: this.testPassedId,
				questionId: this.question.id
			},
			restoreFocus: false
		});
		dialogRef.afterClosed().subscribe((message) => {
			this.reportedMessage = message;
		});
	}
}
