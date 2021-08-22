import { Component, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ReportMessageModalComponent } from '../report-message-modal/report-message-modal.component';
import { CheckCoachQuestion } from '../../interfaces/interfaces';
import { AudioCloudService } from '../../services/audio-cloud.service';

@Component({
	selector: 'app-check-speaking',
	templateUrl: './check-speaking.component.html',
	styleUrls: ['./check-speaking.component.scss']
})
export class CheckSpeakingComponent implements OnInit {
	@Input() testTopicAnswers: CheckCoachQuestion;
	reportComment = 'asd';
	speakingMark = 1;
	themeSpeaking = 'Olympic games';

	constructor(public dialog: MatDialog, private cloudService: AudioCloudService) {}

	ngOnInit(): void {
		this.cloudService.setSpeakingUrl(
			'https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3'
		);
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
