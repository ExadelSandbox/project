import { Component, Input, OnInit, ViewEncapsulation } from '@angular/core';
import { StreamState } from '../../interfaces/stream-state';
import { Question } from '../../interfaces/interfaces';
import { configPopUpTopFull, NotificationService } from '../../services/notification.service';
import { TranslateService } from '@ngx-translate/core';
import { AuditionService } from '../../services/audition.service';
import { AudioCloudService } from '../../services/audio-cloud.service';
import { CheckTestItemPageComponent } from '../../pages/check-test-item-page/check-test-item-page.component';

@Component({
	selector: 'app-coach-player',
	templateUrl: './coach-player.component.html',
	styleUrls: ['./coach-player.component.scss'],
	encapsulation: ViewEncapsulation.None
})
export class CoachPlayerComponent implements OnInit {
	@Input() audioUrl: string;
	files: Array<any> = [];
	state: StreamState | undefined;
	currentFile: any = {};
	testQuestions: Question[] = [];
	configToaster = configPopUpTopFull;
	private translateService: TranslateService;

	constructor(
		private audioService: AuditionService,
		private cloudService: AudioCloudService,
		private notification: NotificationService,
		private checkTest: CheckTestItemPageComponent,
		translateService: TranslateService
	) {
		this.translateService = translateService;
	}

	ngOnInit() {
		this.cloudService.getFiles().subscribe((files) => {
			this.files = files;
		});

		this.audioService.getState().subscribe((state) => {
			this.state = state;
		});
	}

	playStream(url: string) {
		this.audioService.playStream(url).subscribe((events) => {});
	}

	streamActive = false;

	pause() {
		if (this.audioService.state.playing) {
			this.audioService.pause();
		} else {
			this.audioService.play();
		}
	}

	openFile() {
		this.currentFile = null;
		if (this.checkTest.currentTab === 'Listening') {
			this.currentFile = this.cloudService.listeningUrl;
		} else if (this.checkTest.currentTab === 'Speaking') {
			this.currentFile = this.cloudService.speakingUrl;
		}
		if (!this.streamActive) {
			this.audioService.stop();
			this.playStream(this.currentFile[0].url);
			this.streamActive = !this.streamActive;
		}
	}

	play() {
		this.audioService.play();
	}

	stop() {
		this.audioService.stop();
	}

	onSliderChangeEnd(change: any) {
		this.audioService.seekTo(change.value);
	}
}
