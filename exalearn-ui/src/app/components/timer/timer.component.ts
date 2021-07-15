import { Component, OnInit } from '@angular/core';

// Test time is set to 1 hour (in seconds)
const TEST_DURATION = 3600;

@Component({
	selector: 'app-timer',
	templateUrl: './timer.component.html',
	styleUrls: ['./timer.component.scss']
})
export class TimerComponent implements OnInit {
	mins: string = '60';
	secs: string = '00';

	constructor() {}

	ngOnInit(): void {
		this.startTimer();
	}

	startTimer() {
		let timer = TEST_DURATION;

		const displayTimeLeft = () => {
			let minutes = Math.floor(timer / 60),
				seconds = timer % 60;

			const objTime = this.formatTime(minutes, seconds);

			timer--;

			// if timer is below 0, set min/sec to '00' and clear interval
			if (timer < 0) {
				this.mins = '00';
				this.secs = '00';
				clearInterval(timerInterval);
			} else {
				this.mins = objTime.mins;
				this.secs = objTime.secs;
			}
		};

		const timerInterval = setInterval(displayTimeLeft, 1000);
	}

	// Add zero to mins/secs if they are below 10;
	formatTime(minutes: number, seconds: number) {
		let mins = minutes < 10 ? `0${minutes}` : String(minutes);
		let secs = seconds < 10 ? `0${seconds}` : String(seconds);

		return { mins, secs };
	}
}
