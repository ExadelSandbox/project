import { Injectable } from '@angular/core';
import { interval, Observable, Observer } from 'rxjs';
import { LeaveTestModalComponent } from '../components/leave-test-modal/leave-test-modal.component';
import { MatDialog } from '@angular/material/dialog';

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

	constructor(public dialog: MatDialog) {}

	timerObservable: Observable<boolean> = new Observable((observer: Observer<any>) => {
		setTimeout(() => {
			observer.next(true);
		}, SPEAKING_DURATION * 1000);
	});

	displayTimeLeft(interval: any, mins: string, secs: string) {
		const minutes = Math.floor(this.testTotalTimer / 60),
			seconds = this.testTotalTimer % 60;

		const objTime = this.formatTime(minutes, seconds);

		this.testTotalTimer--;

		// if timer is below 0, set min/sec to '00' and clear interval
		if (this.testTotalTimer < 0) {
			mins = '00';
			secs = '00';
			clearInterval(interval);
			this.dialog.open(LeaveTestModalComponent);
		} else {
			mins = objTime.mins;
			secs = objTime.secs;
		}

		return { mins, secs };
	}

	displayTimePassed(interval: any, mins: string, secs: string) {
		const minutes = Math.floor(this.speakingTimer / 60),
			seconds = this.speakingTimer % 60;

		const objTime = this.formatTime(minutes, seconds);
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

	pauseTimer(interval: any) {
		clearInterval(interval);
	}

	resetTimer(interval: any) {
		clearInterval(interval);
		this.speakingTimer = 0;
	}

	// Add zero to mins/secs if they are below 10;
	formatTime(minutes: number, seconds: number) {
		const mins = minutes < 10 ? `0${minutes}` : String(minutes);
		const secs = seconds < 10 ? `0${seconds}` : String(seconds);

		return { mins, secs };
	}
}
