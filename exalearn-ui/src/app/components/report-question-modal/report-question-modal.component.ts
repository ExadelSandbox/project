import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
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
	commentMaxLength = 512;

	constructor(
		public dialogRef: MatDialogRef<ReportQuestionModalComponent>,
		@Inject(MAT_DIALOG_DATA) public data: { passedTestId: number; questionId: number; topicType?: string },
		public submit: SubmitTestService
	) {}

	checkRussian(textarea: any) {
		let reg = /[а-яА-ЯёЁ]/g;
		if (textarea.value.search(reg) != -1) {
			textarea.value = textarea.value.replace(reg, '');
		}
	}

	closeModal() {
		this.dialogRef.close();
	}

	addReported() {
		let answer: testAnswer;
		let indexOfAnswers: string | number;
		if (this.data.topicType) {
			answer = this.submit.getData().get(this.data.topicType);
			indexOfAnswers = this.data.topicType;
		} else {
			answer = this.submit.getData().get(this.data.questionId);
			indexOfAnswers = this.data.questionId;
		}
		if (answer) {
			this.submit.addData(indexOfAnswers, { ...answer, reportedMessage: this.commentFormControl.value });
		} else {
			const currentAnswer: testAnswer = {
				id: 0,
				passedTestId: this.data.passedTestId,
				questionId: this.data.questionId,
				reportedMessage: this.commentFormControl.value,
				userAnswer: '',
				assessment: 0
			};
			this.submit.addData(indexOfAnswers, currentAnswer);
		}
	}
}
