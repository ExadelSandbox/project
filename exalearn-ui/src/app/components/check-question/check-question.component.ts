import { Component, Input, OnInit } from '@angular/core';
import { CheckQuestion } from '../../interfaces/interfaces';
import { checkQuestions } from '../../test-data/test-questions';
import { MatDialog } from '@angular/material/dialog';
import { ReportMessageModalComponent } from '../report-message-modal/report-message-modal.component';

@Component({
	selector: 'app-check-question',
	templateUrl: './check-question.component.html',
	styleUrls: ['./check-question.component.scss']
})
export class CheckQuestionComponent implements OnInit {
	@Input() question: CheckQuestion;
	testQuestions: CheckQuestion[] = [];
	constructor(public dialog: MatDialog) {}

	ngOnInit() {
		this.testQuestions = checkQuestions;
	}

	openReportComment(comment: string) {
		this.dialog.open(ReportMessageModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: {
				modalHeader: 'REPORT_MESSAGE_MODAL.USER_REPORTED_THIS_QUESTION',
				comment
			}
		});
	}
}
