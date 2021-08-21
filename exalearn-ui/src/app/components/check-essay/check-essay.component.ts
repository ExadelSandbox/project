import { Component, Input, OnInit } from '@angular/core';
import { CheckCoachQuestion } from '../../interfaces/interfaces';
import { ReportMessageModalComponent } from '../report-message-modal/report-message-modal.component';
import { MatDialog } from '@angular/material/dialog';

@Component({
	selector: 'app-check-essay',
	templateUrl: './check-essay.component.html',
	styleUrls: ['./check-essay.component.scss']
})
export class CheckEssayComponent implements OnInit {
	@Input() testTopicAnswers: CheckCoachQuestion;
	reportComment: string;
	fillingEssay = 512;
	essayMark = 1;

	constructor(public dialog: MatDialog) {}

	ngOnInit(): void {
		this.reportComment = this.testTopicAnswers.reportedMessage;
	}

	openReportComment(comment: string): void {
		this.dialog.open(ReportMessageModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: {
				modalHeader: 'REPORT_MESSAGE_MODAL.USER_REPORTED_THIS_TOPIC',
				comment
			}
		});
	}

	setMark(mark: number): void {
		this.essayMark = mark;
	}
}
