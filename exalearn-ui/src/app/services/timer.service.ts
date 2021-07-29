import { Injectable } from '@angular/core';
import { Observable, Observer } from 'rxjs';

const TEST_DURATION = 3600;
const SPEAKING_DURATION = 10;
const SPEAKING_MINS = '05';
@Injectable({
	providedIn: 'root'
})
export class TimerService {
	public testTotalTimer: number = TEST_DURATION;
	public speakingTimer = 0;
	public time: { mins: string; secs: string } = { mins: '00', secs: '00' };

	timerObservable: Observable<boolean> = new Observable((observer: Observer<any>) => {
		const timerInterval = setInterval(() => {
			observer.next(this.speakingTimer >= SPEAKING_DURATION);
			this.displayTimePassed(timerInterval, this.time.mins, this.time.secs);
		}, 1000);
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

		// if timer is up 5mins, set min/sec to '05/00' and clear interval
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

	resetTimer() {
		this.speakingTimer = 0;
	}

	// Add zero to mins/secs if they are below 10;
	formatTime(minutes: number, seconds: number) {
		const mins = minutes < 10 ? `0${minutes}` : String(minutes);
		const secs = seconds < 10 ? `0${seconds}` : String(seconds);

		return { mins, secs };
	}
}
