import { Component, OnInit, Input, OnChanges, SimpleChanges, ViewChild } from '@angular/core';
import { TimerService } from '../../services/timer.service';
import { Subscription } from 'rxjs';

@Component({
	selector: 'app-timer',
	templateUrl: './timer.component.html',
	styleUrls: ['./timer.component.scss'],
	providers: [TimerService]
})
export class TimerComponent implements OnInit, OnChanges {
	@Input() startTimerOnInit = false;
	@Input() speakingTimerStarted = false;
	@Input() label = ``;
	@Input() mode = ``;
	@Input() resetSpeakingTimer = false;
	time: { mins: string; secs: string } = { mins: '00', secs: '00' };
	speakingTimerInterval: any;
	timerObservable: Subscription;

	constructor(private timerService: TimerService) {}

	ngOnInit(): void {
		if (this.startTimerOnInit) {
			this.startTotalDurationTimer();
		}
	}

	ngOnChanges(changes: SimpleChanges) {
		if (this.speakingTimerStarted) {
			this.startSpeakingTimer();
		} else {
			this.timerService.pauseTimer(this.speakingTimerInterval);
		}

		if (this.resetSpeakingTimer) {
			this.timerService.resetTimer(this.speakingTimerInterval);
		}
	}

	startTotalDurationTimer() {
		const timerInterval = setInterval(() => {
			this.time = this.timerService.displayTimeLeft(timerInterval, this.time.mins, this.time.secs);
		}, 1000);
	}

	startSpeakingTimer() {
		this.speakingTimerInterval = setInterval(() => {
			this.time = this.timerService.displayTimePassed(this.speakingTimerInterval, this.time.mins, this.time.secs);
		}, 1000);
	}
}
