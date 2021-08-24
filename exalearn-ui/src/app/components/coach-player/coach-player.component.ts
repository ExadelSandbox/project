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

	streamActive = false;

	pause() {
		this.audioService.pause();
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
