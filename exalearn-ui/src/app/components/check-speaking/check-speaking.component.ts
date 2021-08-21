import { Component, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ReportMessageModalComponent } from '../report-message-modal/report-message-modal.component';
import { CheckCoachQuestion } from '../../interfaces/interfaces';

@Component({
	selector: 'app-check-speaking',
	templateUrl: './check-speaking.component.html',
	styleUrls: ['./check-speaking.component.scss']
})
export class CheckSpeakingComponent implements OnInit {
	@Input() testTopicAnswers: CheckCoachQuestion;
	reportComment: string;
	speakingMark = 1;
	themeSpeaking = 'Olympic games';

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
		this.speakingMark = mark;
	}
}
