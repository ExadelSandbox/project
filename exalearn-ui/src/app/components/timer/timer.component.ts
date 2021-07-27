import { Component, OnInit, Input, OnChanges, SimpleChanges } from '@angular/core';
import { TimerService } from '../../services/timer.service';

@Component({
	selector: 'app-timer',
	templateUrl: './timer.component.html',
	styleUrls: ['./timer.component.scss'],
	providers: [TimerService]
})
export class TimerComponent implements OnInit, OnChanges {
	@Input() startTimerOnInit: boolean = false;
	@Input() speakingTimerStarted: boolean = false;
	time: { mins: string; secs: string } = { mins: '00', secs: '00' };
	speakingTimerInterval: any;

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
