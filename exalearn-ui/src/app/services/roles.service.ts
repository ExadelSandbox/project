import { Injectable } from '@angular/core';
import { RedirectBtn } from '../interfaces/interfaces';

@Injectable({
	providedIn: 'root'
})
export class RolesService {
	private userBtns: readonly RedirectBtn[] = [
		{ name: 'my tests history', url: '/history' },
		{ name: 'pass test', url: '/test' },
		{ name: 'my assigned tests', url: '/assigned' }
	];
	private hrBtns: readonly RedirectBtn[] = [
		{ name: 'all tests history', url: '/all-history' },
		{ name: 'assign test', url: '/assign' },
		{ name: 'all assigned tests', url: '/all-assigned' }
	];
	private coachBtns: readonly RedirectBtn[] = [
		{ name: 'create question', url: '/create' },
		{ name: 'view questions', url: '/questions' },
		{ name: 'check tests', url: '/check' },
		{ name: 'reported questions', url: '/reported' }
	];
	private adminBtns: readonly RedirectBtn[] = [
		{ name: 'statistics gathering', url: '/statistics' },
		{ name: 'reassign test', url: '/reassign' },
		{ name: 'reported questions', url: '/reported' }
	];

	constructor() {}

	getBtns(role: 'user' | 'hr' | 'coach' | 'admin'): readonly RedirectBtn[] {
		switch (role) {
			case 'user':
				return this.userBtns;
			case 'hr':
				return this.userBtns.concat(this.hrBtns);
			case 'coach':
				return this.userBtns.concat(this.coachBtns);
			case 'admin':
				return this.userBtns.concat(this.adminBtns);
			default:
				return [];
		}
	}
}
