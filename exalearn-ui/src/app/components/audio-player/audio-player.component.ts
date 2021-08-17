import { Component, Input, OnInit, ViewEncapsulation } from '@angular/core';
import { StreamState } from '../../interfaces/stream-state';
import { Question } from '../../interfaces/interfaces';
import { AuditionService } from '../../services/audition.service';
import { AudioCloudService } from '../../services/audio-cloud.service';
import { NotificationService } from '../../services/notification.service';
import { configPopUpTopFull } from '../../services/notification.service';

@Component({
	selector: 'app-audio-player',
	templateUrl: './audio-player.component.html',
	styleUrls: ['./audio-player.component.scss'],
	encapsulation: ViewEncapsulation.None
})
export class AudioPlayerComponent implements OnInit {
	files: Array<any> = [];
	state: StreamState | undefined;
	currentFile: any = {};
	testQuestions: Question[] = [];
	currentAttempts = 0;
	ATTEMPTS_NUMBER = 3;
	configToaster = configPopUpTopFull;

	constructor(
		private audioService: AuditionService,
		private cloudService: AudioCloudService,
		private notification: NotificationService
	) {}

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

	pause() {
		this.audioService.pause();
	}

	play(file: any, index: number) {
		if (this.currentAttempts < 3) {
			this.currentAttempts++;
			this.currentFile = { index, file };
			if (!file.url) {
				this.notification.errorPopUp('File url is invalid, try later');
			} else {
				this.playStream(file.url);
				this.audioService.play();
			}
		} else {
			this.notification.errorPopUp('Ended the number of attempts');
		}
	}

	stop() {
		this.audioService.stop();
	}

	onSliderChangeEnd(change: any) {
		this.audioService.seekTo(change.value);
	}
}
