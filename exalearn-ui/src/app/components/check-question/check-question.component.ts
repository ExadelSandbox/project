import { Component, Input, OnInit } from '@angular/core';
import { CheckCoachQuestion } from '../../interfaces/interfaces';
import { MatDialog } from '@angular/material/dialog';
import { ReportMessageModalComponent } from '../report-message-modal/report-message-modal.component';

@Component({
	selector: 'app-check-question',
	templateUrl: './check-question.component.html',
	styleUrls: ['./check-question.component.scss']
})
export class CheckQuestionComponent implements OnInit {
	@Input() answer: CheckCoachQuestion;
	@Input() currentIndex: number;

	constructor(public dialog: MatDialog) {}

	ngOnInit() {}

	openReportComment(comment: string): void {
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
