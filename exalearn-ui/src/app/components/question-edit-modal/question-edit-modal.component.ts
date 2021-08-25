import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { CheckCoachAnswers, CheckCoachQuestion } from '../../interfaces/interfaces';
import { ApiService } from '../../services/api.service';
import { API_PATH } from '../../constants/api.constants';

@Component({
	selector: 'app-question-edit-modal',
	templateUrl: './question-edit-modal.component.html',
	styleUrls: ['./question-edit-modal.component.scss']
})
export class QuestionEditModalComponent implements OnInit {
	isEditable = false;
	questionValue: string;
	answers: CheckCoachAnswers[] | undefined;
	constructor(
		public dialogRef: MatDialogRef<QuestionEditModalComponent>,
		@Inject(MAT_DIALOG_DATA)
		public data: { modalHeader: string; questionName: string; answer: CheckCoachQuestion },
		public apiService: ApiService
	) {}

	ngOnInit(): void {
		this.data.answer.answers
			? (this.answers = JSON.parse(JSON.stringify(this.data.answer.answers)))
			: (this.answers = undefined);
		this.questionValue = this.data.answer.questionText;
	}
	closeModal(): void {
		this.dialogRef.close();
	}
	deleteQuestion(): void {
		this.data.answer.isArchive = true;
		if (this.data.answer.text) {
			const question = JSON.parse(JSON.stringify(this.data.answer));
			delete question.questionText;
			delete question.level;
			this.apiService.postRequest(API_PATH.DELETE_QUESTION, question);
		} else {
			this.apiService.getRequest(API_PATH.GET_QUESTION, { id: this.data.answer.questionId }).then((question) => {
				question.isArchive = true;
				this.apiService.postRequest(API_PATH.DELETE_QUESTION, question);
			});
		}
		this.dialogRef.close();
	}
	startEditQuestion(): void {
		this.isEditable = true;
	}
	editQuestion(): void {
		if (this.answers) this.data.answer.answers = this.answers;
		this.data.answer.questionText = this.questionValue;
		if (this.data.answer.text) {
			const question = JSON.parse(JSON.stringify(this.data.answer));
			if (question.answers) question.answers = this.answers;
			question.text = this.questionValue;
			delete question.questionText;
			delete question.level;
			this.apiService.postRequest(API_PATH.EDIT_QUESTION, question);
		} else {
			this.apiService.getRequest(API_PATH.GET_QUESTION, { id: this.data.answer.questionId }).then((question) => {
				question.text = this.questionValue;
				if (question.answers) question.answers = this.answers;
				this.apiService.postRequest(API_PATH.EDIT_QUESTION, question);
			});
		}

		this.dialogRef.close();
	}
}
