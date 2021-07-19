import { Injectable } from '@angular/core';

@Injectable({
	providedIn: 'root'
})
export default class UtilsService {}

export function formatTimeAudio(time: number) {
	return `${Math.floor(time / 60)} : ${String('0' + Math.floor(time % 60)).slice(-2)}`;
}

export function formatTimeTimer(minutes: number, seconds: number) {
	const mins = minutes < 10 ? `0${minutes}` : String(minutes);
	const secs = seconds < 10 ? `0${seconds}` : String(seconds);

	return { mins, secs };
}
