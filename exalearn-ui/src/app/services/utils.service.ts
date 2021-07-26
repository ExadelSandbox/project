import { Injectable } from '@angular/core';
import { HttpHeaders } from '@angular/common/http';

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

export const headers = new HttpHeaders({
	'Access-Control-Allow-Origin': 'http://185.87.50.51/api/authenticate; charset=utf-8'
});
