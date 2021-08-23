import { Component, Input, OnInit } from '@angular/core';
import { ToasterConfig } from 'angular2-toaster';
import { environment } from '../../../environments/environment.prod';
import { AudioCloudService } from '../../services/audio-cloud.service';
import { MediaRecorder } from 'extendable-media-recorder';
import { TimerService } from '../../services/timer.service';
import { Subscription } from 'rxjs';
import SubmitTestService from '../../services/submit-test.service';
import { testAnswer, Topic } from '../../interfaces/interfaces';
import { NotificationService } from '../../services/notification.service';
import { configPopUp } from '../../services/notification.service';
import { ReportQuestionModalComponent } from '../report-question-modal/report-question-modal.component';
import { MatDialog } from '@angular/material/dialog';
import { TranslateService } from '@ngx-translate/core';

@Component({
	selector: 'app-speaking',
	templateUrl: './speaking.component.html',
	styleUrls: ['./speaking.component.scss']
})
export class SpeakingComponent implements OnInit {
	@Input() questionsSpeaking: any;
	@Input() testPassedId: number;

	topic: Topic;
	public recording: boolean;
	public recorder: Promise<MediaStream>;
	public speakingTimerStarted: boolean;
	public resetSpeakingTimer: boolean;
	public speakingTimer: number;
	public innerText = 'Recording:';
	public timerSubscriber: Subscription;
	public audioUrlCloud: string;
	public configPop: ToasterConfig;

	private mediaRecorder: any;
	private chunks: Blob[] = [];
	public isDataAvailable: boolean;
	public isRecordReadySpinner = false;
	readonly recordingDuration: number = 5 * 60000;

	public audioLink: string;
	public reportedMessage: string | null = null;
	constructor(
		private audioStorage: AudioCloudService,
		private timerService: TimerService,
		public submit: SubmitTestService,
		private notificationService: NotificationService,
		private translateService: TranslateService,
		public dialog: MatDialog
	) {
		this.configPop = configPopUp;
		this.translateService = translateService;
	}

	ngOnInit(): void {
		if (this.questionsSpeaking.length === 0) {
			this.isDataAvailable = false;
		} else {
			this.recording = false;
			this.speakingTimerStarted = false;
			this.resetSpeakingTimer = false;
			this.speakingTimer = this.timerService.speakingTimer;
			this.audioUrlCloud = '';
			this.topic = this.questionsSpeaking;
			this.isDataAvailable = true;
		}
	}

	startRecording(): void {
		this.recorder = navigator.mediaDevices.getUserMedia({ audio: true });
		void this.recorder.then((stream) => {
			this.mediaRecorder = new MediaRecorder(stream);
			this.speakingTimerStarted = true;
			this.recording = true;
			this.mediaRecorder.start(this.recordingDuration);
			this.getData();
			if (this.audioUrlCloud != '') {
				this.deleteAudioFromCloudService();
			}
			this.timerSubscribe();
		});
	}

	stopRecording(): void {
		if (this.recording) {
			this.speakingTimerStarted = false;
			this.resetSpeakingTimer = false;
			this.recording = false;
			this.mediaRecorder.stop();
			this.createAudio();
		}
		this.timerSubscriber.unsubscribe();
	}

	getData(): void {
		this.chunks = [];
		this.mediaRecorder.ondataavailable = (event: any) => {
			this.chunks.push(event.data);
		};
	}

	createAudio(): void {
		this.mediaRecorder.onstop = async () => {
			const audioBlob = new Blob(this.chunks, { type: 'audio/webm; codecs=opus' });
			const audioUrl = URL.createObjectURL(audioBlob);
			const audio = new Audio(audioUrl);
			await this.pushAudioToCloudService();
		};
	}

	timerSubscribe(): void {
		this.timerSubscriber = this.timerService.timerObservable.subscribe((count) => {
			count && this.stopRecording();
		});
	}

	collectAudioAnswer(url: string): void {
		this.audioUrlCloud = url;
		const speakingAnswer: testAnswer = {
			id: 0,
			passedTestId: this.testPassedId,
			questionId: this.topic.id,
			reportId: null,
			reportedMessage: this.reportedMessage,
			userAnswer: this.audioUrlCloud,
			assessment: 0
		};
		this.submit.addData('speaking', speakingAnswer);
	}

	async pushAudioToCloudService(): Promise<void> {
		const file = new File(this.chunks, 'recording.webm');
		this.isDataAvailable = true;
		this.isRecordReadySpinner = true;
		await this.audioStorage
			.uploadAudio(file, environment.cloudSpeaking)
			.then((url) => {
				this.collectAudioAnswer(url);
				this.isRecordReadySpinner = false;
				this.recording = false;
			})
			.catch(() => {
				this.notificationService.errorPopUp(this.translateService.instant('NOTIFICATION.ERROR_TRY_AGAIN'));
				this.isRecordReadySpinner = true;
				this.recording = false;
			});
	}

	deleteAudioFromCloudService(): void {
		this.audioStorage.deleteAudio(this.audioUrlCloud);
	}
	openReportDialog(): void {
		const dialogRef = this.dialog.open(ReportQuestionModalComponent, {
			width: '100%',
			maxWidth: 500,
			data: {
				passedTestId: this.testPassedId,
				questionId: this.topic.id,
				topicType: 'speaking'
			}
		});
		dialogRef.afterClosed().subscribe((message) => {
			this.reportedMessage = message;
		});
	}
}
