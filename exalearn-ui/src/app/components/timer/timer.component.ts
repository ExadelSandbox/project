import { Component, OnInit } from '@angular/core';
import { TimerService } from '../../services/timer.service';

@Component({
	selector: 'app-timer',
	templateUrl: './timer.component.html',
	styleUrls: ['./timer.component.scss'],
	providers: [TimerService]
})
export class TimerComponent implements OnInit {
	time: { mins: string; secs: string } = { mins: '60', secs: '60' };
	speakingTime: { mins: string; secs: string } = { mins: '00', secs: '00' };

	constructor(private timerService: TimerService) {}

	ngOnInit(): void {
		this.startTotalDurationTimer();
	}

	startTotalDurationTimer() {
		const timerInterval = setInterval(() => {
			this.time = this.timerService.displayTimeLeft(timerInterval, this.time.mins, this.time.secs);
		}, 1000);
	}

	startSpeakingTimer() {
		const speakingTimerInterval = setInterval(() => {
			this.speakingTime = this.timerService.displayTimePassed(
				speakingTimerInterval,
				this.speakingTime.mins,
				this.speakingTime.secs
			);
		}, 1000);
	}
}
