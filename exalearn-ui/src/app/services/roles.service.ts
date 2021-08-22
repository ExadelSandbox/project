import { Injectable } from '@angular/core';
import { RedirectBtn } from '../interfaces/interfaces';
import { RoleNames } from '../enums/enums';

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
		{ name: 'MAIN.CHECK_TESTS', url: '/check-test-list' },
		{ name: 'MAIN.QUESTIONS', url: '/question-check' }
	];
	private adminBtns: readonly RedirectBtn[] = [
		{ name: 'MAIN.STATISTICS_GATHERING', url: '/statistics' },
		{ name: 'MAIN.REASSIGN_TEST', url: '/reassign' },
		{ name: 'MAIN.REPORTED_QUESTIONS', url: '/reported' }
	];

	constructor() {}

	getBtns(role: string): readonly RedirectBtn[] {
		switch (role) {
			case RoleNames.User:
				return this.userBtns;
			case RoleNames.HR:
				return this.userBtns.concat(this.hrBtns);
			case RoleNames.Coach:
				return this.userBtns.concat(this.coachBtns);
			default:
				return [];
		}
	}
}
