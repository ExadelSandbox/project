import { Component, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ReportMessageModalComponent } from '../report-message-modal/report-message-modal.component';
import { CheckCoachQuestion } from '../../interfaces/interfaces';
import { QuestionEditModalComponent } from '../question-edit-modal/question-edit-modal.component';
import { AudioCloudService } from '../../services/audio-cloud.service';
import { AuditionService } from '../../services/audition.service';

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

	constructor(
		public dialog: MatDialog,
		private cloudService: AudioCloudService,
		public auditionService: AuditionService
	) {}

	ngOnInit(): void {
		this.cloudService.setSpeakingUrl(this.testTopicAnswers.userAnswer);
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
	openEditQuestion(): void {
		this.dialog.open(QuestionEditModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: {
				modalHeader: 'QUESTION_EDIT_MODAL.EDIT_OR_DELETE_TOPIC',
				questionName: 'QUESTION_EDIT_MODAL.TOPIC',
				answer: this.testTopicAnswers
			}
		});
	}
	setMark(mark: number): void {
		this.speakingMark = mark;
	}
}
