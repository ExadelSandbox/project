import { Injectable } from '@angular/core';
import { ToasterConfig } from 'angular2-toaster';

@Injectable({
	providedIn: 'root'
})
export default class UtilsService {}

export function formatTimeAudio(time: number | null) {
	if (time === null || time === Infinity) {
		return `-- : --`;
	}
	return `${Math.floor(time / 60)} : ${String('0' + Math.floor(time % 60)).slice(-2)}`;
}

export function formatTimeTimer(minutes: number, seconds: number) {
	const mins = minutes < 10 ? `0${minutes}` : String(minutes);
	const secs = seconds < 10 ? `0${seconds}` : String(seconds);

	return { mins, secs };
}

export const configPopUp: ToasterConfig = new ToasterConfig({
	limit: 1,
	tapToDismiss: true,
	showCloseButton: false,
	mouseoverTimerStop: true,
	animation: 'fade',
	positionClass: 'toast-bottom-right'
});

export const headers = {
	Accept: 'application/json',
	'Access-Control-Allow-Origin': '*',
	'X-Requested-With': 'XMLHttpRequest',
	'Access-Control-Allow-Methods': 'GET,POST,PUT,DELETE,OPTIONS',
	'Access-Control-Allow-Headers': 'Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With'
};
