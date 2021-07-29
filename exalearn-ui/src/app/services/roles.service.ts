import { Injectable } from '@angular/core';
import { RedirectBtn } from '../interfaces/interfaces';

@Injectable({
	providedIn: 'root'
})
export class RolesService {
	private userBtns: readonly RedirectBtn[] = [
		{ name: 'MAIN.MY_TEST_HISTORY', url: '/my-history' },
		{ name: 'MAIN.MY_ASSIGNED_TESTS', url: '/my-assigned-tests' }
	];
	private hrBtns: readonly RedirectBtn[] = [
		{ name: 'MAIN.ALL_TESTS_HISTORY', url: '/all-history' },
		{ name: 'MAIN.ASSIGN_TEST', url: '/assign' },
		{ name: 'MAIN.ALL_ASSIGNED_TESTS', url: '/all-assigned' }
	];
	private coachBtns: readonly RedirectBtn[] = [
		{ name: 'MAIN.CREATE_QUESTION', url: '/create' },
		{ name: 'MAIN.VIEW_QUESTIONS', url: '/questions' },
		{ name: 'MAIN.CHECK_TESTS', url: '/check-test-list' },
		{ name: 'MAIN.REPORTED_QUESTIONS', url: '/reported' }
	];
	private adminBtns: readonly RedirectBtn[] = [
		{ name: 'MAIN.STATISTICS_GATHERING', url: '/statistics' },
		{ name: 'MAIN.REASSIGN_TEST', url: '/reassign' },
		{ name: 'MAIN.REPORTED_QUESTIONS', url: '/reported' }
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
