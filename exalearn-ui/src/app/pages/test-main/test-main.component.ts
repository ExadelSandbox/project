import { Component, OnInit } from '@angular/core';

const TEST_DURATION = 60 * 60;

@Component({
	selector: 'app-test-main',
	templateUrl: './test-main.component.html',
	styleUrls: ['./test-main.component.scss']
})
export class TestMainComponent implements OnInit {
	mins: string = '60';
	secs: string = '00';

	constructor() {}

	ngOnInit(): void {
		this.startTimer();
	}

	startTimer() {
		let timer = TEST_DURATION,
			minutes,
			seconds;

		const displayTimeLeft = () => {
			minutes = parseInt(String(timer / 60), 10);
			seconds = parseInt(String(timer % 60), 10);

			let mins = minutes < 10 ? `0${minutes}` : minutes;
			let secs = seconds < 10 ? `0${seconds}` : seconds;

			if (--timer < 0) {
				mins = '00';
				secs = '00';
				clearInterval(timerInterval);
			}

			this.mins = String(mins);
			this.secs = String(secs);
		};

		const timerInterval = setInterval(displayTimeLeft, 1000);
	}
}
