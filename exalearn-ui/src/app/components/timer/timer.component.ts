import { Component, OnInit } from '@angular/core';

// Test time is set to 1 hour (in seconds)
// TODO: give the ability to set the time duration through a custom attribute
const TEST_DURATION = 3600;

@Component({
	selector: 'app-timer',
	templateUrl: './timer.component.html',
	styleUrls: ['./timer.component.scss']
})
export class TimerComponent implements OnInit {
	mins: string = '60';
	secs: string = '00';
	timer: number = TEST_DURATION;

	constructor() {}

	ngOnInit(): void {
		this.startTimer();
	}

	startTimer() {
		const timerInterval = setInterval(() => {
			this.displayTimeLeft(timerInterval);
		}, 1000);
	}

	displayTimeLeft(interval: any) {
		let minutes = Math.floor(this.timer / 60),
			seconds = this.timer % 60;

		const objTime = this.formatTime(minutes, seconds);

		this.timer--;

		// if timer is below 0, set min/sec to '00' and clear interval
		if (this.timer < 0) {
			this.mins = '00';
			this.secs = '00';
			clearInterval(interval);
		} else {
			this.mins = objTime.mins;
			this.secs = objTime.secs;
		}
	}

	// Add zero to mins/secs if they are below 10;
	formatTime(minutes: number, seconds: number) {
		let mins = minutes < 10 ? `0${minutes}` : String(minutes);
		let secs = seconds < 10 ? `0${seconds}` : String(seconds);

		return { mins, secs };
	}
}
