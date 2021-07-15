import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject, Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';

import { StreamState } from '../interfaces/stream-state';

@Injectable({
	providedIn: 'root'
})
// eslint-disable-next-line @typescript-eslint/ban-ts-comment
// @ts-ignore
export class AuditionService {
	private stop$ = new Subject();
	private audioObj = new Audio();
	audioEvents = [
		'ended',
		'error',
		'play',
		'playing',
		'pause',
		'timeupdate',
		'canplay',
		'loadedmetadata',
		'loadstart'
	];
	private state: StreamState = {
		playing: false,
		readableCurrentTime: '',
		readableDuration: '',
		duration: undefined,
		currentTime: undefined,
		canplay: false,
		error: false
	};

	private streamObservable(url: any) {
		return new Observable((observer) => {
			// Play audio
			this.audioObj.src = url;
			this.audioObj.load();
			void this.audioObj.play();

			const handler = (event: Event) => {
				this.updateStateEvents(event);
				observer.next(event);
			};

			this.addEvents(this.audioObj, this.audioEvents, handler);
			return () => {
				// Stop Playing
				this.audioObj.pause();
				this.audioObj.currentTime = 0;
				// remove event listeners
				this.removeEvents(this.audioObj, this.audioEvents, handler);
				// reset state
				this.resetState();
			};
		});
	}

	private addEvents(obj: any, events: any, handler: any) {
		events.forEach((event: any) => {
			obj.addEventListener(event, handler);
		});
	}

	private removeEvents(obj: any, events: any, handler: any) {
		events.forEach((event: any) => {
			obj.removeEventListener(event, handler);
		});
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	playStream(url: string) {
		return this.streamObservable(url).pipe(takeUntil(this.stop$));
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	play() {
		void this.audioObj.play();
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	pause() {
		this.audioObj.pause();
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	stop() {
		this.stop$.next();
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	seekTo(seconds: number) {
		this.audioObj.currentTime = seconds;
	}

	// eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
	formatTime(time: number) {
		// eslint-disable-next-line @typescript-eslint/restrict-plus-operands
		return Math.floor(time / 60) + ':' + ('0' + Math.floor(time % 60)).slice(-2);
	}

	private stateChange: BehaviorSubject<StreamState> = new BehaviorSubject(this.state);

	private updateStateEvents(event: Event): void {
		switch (event.type) {
			case 'canplay':
				this.state.duration = this.audioObj.duration;
				this.state.readableDuration = this.formatTime(this.state.duration);
				this.state.canplay = true;
				break;
			case 'playing':
				this.state.playing = true;
				break;
			case 'pause':
				this.state.playing = false;
				break;
			case 'timeupdate':
				this.state.currentTime = this.audioObj.currentTime;
				this.state.readableCurrentTime = this.formatTime(this.state.currentTime);
				break;
			case 'error':
				this.resetState();
				this.state.error = true;
				break;
		}
		this.stateChange.next(this.state);
	}

	private resetState() {
		this.state = {
			playing: false,
			readableCurrentTime: '',
			readableDuration: '',
			duration: undefined,
			currentTime: undefined,
			canplay: false,
			error: false
		};
	}

	getState(): Observable<StreamState> {
		return this.stateChange.asObservable();
	}
}
