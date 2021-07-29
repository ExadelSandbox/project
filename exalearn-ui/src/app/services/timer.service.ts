import { Injectable } from '@angular/core';
import { Observable, Observer } from 'rxjs';

const TEST_DURATION = 3600;
const SPEAKING_DURATION = 300;
const SPEAKING_MINS = '05';

@Injectable({
	providedIn: 'root'
})
export class TimerService {
	testTotalTimer: number = TEST_DURATION;
	speakingTimer: number = 0;
	time: { mins: string; secs: string } = { mins: '00', secs: '00' };

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
