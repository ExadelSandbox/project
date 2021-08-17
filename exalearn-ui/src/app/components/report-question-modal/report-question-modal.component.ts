import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { FormControl, Validators } from '@angular/forms';
import SubmitTestService from '../../services/submit-test.service';
import { testAnswer } from '../../interfaces/interfaces';

@Component({
	selector: 'app-report-question-modal',
	templateUrl: './report-question-modal.component.html',
	styleUrls: ['./report-question-modal.component.scss']
})
export class ReportQuestionModalComponent {
	commentFormControl = new FormControl('', Validators.required);
	constructor(
		@Inject(MAT_DIALOG_DATA) public data: { passedTestId: number; questionId: number },
		public submit: SubmitTestService
	) {}
	addReported() {
		const answer = this.submit.getData().get(this.data.questionId);
		if (answer) {
			this.submit.addData(this.data.questionId, { ...answer, reportedMessage: this.commentFormControl.value });
		} else {
			const currentAnswer: testAnswer = {
				id: 0,
				passedTestId: this.data.passedTestId,
				questionId: this.data.questionId,
				reportId: null,
				reportedMessage: this.commentFormControl.value,
				answer: '',
				assessment: 0
			};
			this.submit.addData(this.data.questionId, currentAnswer);
		}
	}
}
