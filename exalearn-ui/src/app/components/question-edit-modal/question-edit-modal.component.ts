import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { CheckCoachAnswers, CheckCoachQuestion } from '../../interfaces/interfaces';

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
		public data: { modalHeader: string; questionName: string; answer: CheckCoachQuestion }
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
		this.data.answer.isDeleted = true;
		this.dialogRef.close();
	}
	startEditQuestion(): void {
		this.isEditable = true;
	}
	editQuestion(): void {
		if (this.answers) this.data.answer.answers = this.answers;
		this.data.answer.questionText = this.questionValue;
		this.dialogRef.close();
	}
}
