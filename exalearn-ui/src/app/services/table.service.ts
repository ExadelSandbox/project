//TODO: remove test data after back-end integration
import { Injectable } from '@angular/core';
import { EnglishLevels } from '../enums/enums';
import { PassedTest, User, Assignment } from '../interfaces/interfaces';
import {
	mockAssigner,
	mockChecker,
	ALL_TESTS_DATA,
	MY_ASSIGNED_DATA,
	MY_TESTS_DATA,
	USERS_DATA,
	MY_ASSIGNMENTS_DATA
} from '../test-data/tables-mock-data';

@Injectable({
	providedIn: 'root'
})
export class TableService {
	mockAssigner: User = mockAssigner;
	mockChecker: User = mockChecker;
	USERS_DATA: User[] = USERS_DATA;
	ALL_TESTS_DATA: PassedTest[] = ALL_TESTS_DATA;
	MY_TESTS_DATA: PassedTest[] = MY_TESTS_DATA;
	MY_ASSIGNED_DATA: Assignment[] = MY_ASSIGNED_DATA;
	MY_ASSIGNMENTS_DATA: Assignment[] = MY_ASSIGNMENTS_DATA;

	getTableElements(dataType: string): User[] | PassedTest[] | Assignment[] {
		switch (dataType) {
			case 'user':
				return this.USERS_DATA;
			case 'my-tests':
				return this.MY_TESTS_DATA;
			case 'all-tests':
				return this.ALL_TESTS_DATA;
			case 'my-assigned-tests':
				return this.MY_ASSIGNED_DATA;
			case 'tests-assigned-by-user':
				return this.MY_ASSIGNMENTS_DATA;
			default:
				return [];
		}
	}
}
