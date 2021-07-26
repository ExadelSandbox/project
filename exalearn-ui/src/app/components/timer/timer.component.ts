import { Component, OnInit, Input } from '@angular/core';
import { TimerService } from '../../services/timer.service';

@Component({
	selector: 'app-timer',
	templateUrl: './timer.component.html',
	styleUrls: ['./timer.component.scss'],
	providers: [TimerService]
})
export class TimerComponent implements OnInit {
	@Input() startTimerOnInit: boolean = false;
	time: { mins: string; secs: string } = { mins: '00', secs: '00' };

	constructor(private timerService: TimerService) {}

	ngOnInit(): void {
		if (this.startTimerOnInit) {
			this.startTotalDurationTimer();
		}
	}

	startTotalDurationTimer() {
		const timerInterval = setInterval(() => {
			this.time = this.timerService.displayTimeLeft(timerInterval, this.time.mins, this.time.secs);
		}, 1000);
	}

	startSpeakingTimer() {
		const speakingTimerInterval = setInterval(() => {
			this.time = this.timerService.displayTimePassed(speakingTimerInterval, this.time.mins, this.time.secs);
		}, 1000);
	}
}
