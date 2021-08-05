import { Injectable } from '@angular/core';
import { Observable, Observer } from 'rxjs';
import { LeaveTestModalComponent } from '../components/leave-test-modal/leave-test-modal.component';
import { MatDialog } from '@angular/material/dialog';
import { formatTimeTimer } from './utils.service';

//TODO TIMER from 3600 to 30
const TEST_DURATION = 5;
const SPEAKING_DURATION = 300;
const SPEAKING_MINS = '05';

@Injectable({
	providedIn: 'root'
})
export class TimerService {
	public testTotalTimer: number = TEST_DURATION;
	public speakingTimer = 0;
	public time: { mins: string; secs: string } = { mins: '00', secs: '00' };
	public speakingTimerInterval: any;
	public timerInterval: any;
	timeForTimerGod: any;

	constructor(public dialog: MatDialog) {}

	timerObservable: Observable<boolean> = new Observable((observer: Observer<any>) => {
		setTimeout(() => {
			observer.next(true);
		}, SPEAKING_DURATION * 1000);
	});

	testTimerObservable: Observable<any> = new Observable((observer: Observer<any>) => {
		const intervalId = setInterval(() => {
			observer.next(this.timeForTimerGod);
		}, 1000);
		return () => {
			clearInterval(intervalId);
		};
	});

	startTotalDurationTimer() {
		this.timerInterval = setInterval(() => {
			this.time = this.displayTimeLeft(this.timerInterval, this.time.mins, this.time.secs);
		}, 1000);
	}

	startSpeakingTimer() {
		this.speakingTimerInterval = setInterval(() => {
			this.time = this.displayTimePassed(this.speakingTimerInterval, this.time.mins, this.time.secs);
		}, 1000);
	}

	displayTimeLeft(interval: any, mins: string, secs: string) {
		const minutes = Math.floor(this.testTotalTimer / 60),
			seconds = this.testTotalTimer % 60;

		const objTime = formatTimeTimer(minutes, seconds);
		this.testTotalTimer--;

		if (this.testTotalTimer < 0) {
			mins = '00';
			secs = '00';
			clearInterval(interval);
			this.dialog.open(LeaveTestModalComponent);
		} else {
			mins = objTime.mins;
			secs = objTime.secs;
		}
		this.timeForTimerGod = { mins, secs };
		return { mins, secs };
	}

	displayTimePassed(interval: any, mins: string, secs: string) {
		const minutes = Math.floor(this.speakingTimer / 60),
			seconds = this.speakingTimer % 60;

		const objTime = formatTimeTimer(minutes, seconds);
		this.speakingTimer++;

		if (this.speakingTimer > SPEAKING_DURATION) {
			mins = SPEAKING_MINS;
			secs = '00';
			clearInterval(interval);
		} else {
			mins = objTime.mins;
			secs = objTime.secs;
		}
		return { mins, secs };
	}

	pauseTimer() {
		clearInterval(this.timerInterval);
	}

	pauseSpeakingTimer() {
		clearInterval(this.speakingTimerInterval);
	}

	resetSpeakingTimer() {
		clearInterval(this.speakingTimerInterval);
		this.speakingTimer = 0;
	}
}
