//TODO: remove test data after back-end integration
import { Injectable } from '@angular/core';
import { EnglishLevels } from '../enums/enums';
import { PassedTest, User } from '../interfaces/interfaces';

@Injectable({
	providedIn: 'root'
})
export class TableService {
	mockAssigner: User = { name: 'Anna', id: 662, englishLevel: EnglishLevels.C1 };
	mockChecker: User = { name: 'Maximilian', id: 9908, englishLevel: EnglishLevels.C2 };
	USERS_DATA: User[] = [
		{ name: 'Semen', id: 12312, englishLevel: EnglishLevels.B1 },
		{ name: 'Kristie', id: 1562, englishLevel: EnglishLevels.B1 },
		{ name: 'Danya', id: 1292, englishLevel: EnglishLevels.C1 },
		{ name: 'Polina', id: 9912, englishLevel: EnglishLevels.A2 },
		{ name: 'Anna', id: 7202, englishLevel: EnglishLevels.C2 }
	];
	TESTS_DATA: PassedTest[] = [
		{
			id: 12,
			user: { name: 'Dima', id: 12, englishLevel: EnglishLevels.B2 },
			username: 'Dima',
			assigner: this.mockAssigner,
			checker: this.mockChecker,
			date: new Date('2021-05-17T04:24:00'),
			level: EnglishLevels.B2,
			score: {
				testSections: [
					{ sectionName: 'grammar', sectionScore: 17 },
					{ sectionName: 'listening', sectionScore: 19 },
					{ sectionName: 'speaking', sectionScore: 19 },
					{ sectionName: 'writing', sectionScore: 19 }
				],
				total: 74
			}
		},
		{
			id: 122,
			user: { name: 'Dennis', id: 122, englishLevel: EnglishLevels.C1 },
			username: 'Dennis',
			assigner: this.mockAssigner,
			checker: this.mockChecker,
			date: new Date('2020-05-27T04:04:00'),
			level: EnglishLevels.B1,
			score: {
				testSections: [
					{ sectionName: 'grammar', sectionScore: 15 },
					{ sectionName: 'listening', sectionScore: 11 },
					{ sectionName: 'speaking', sectionScore: 9 },
					{ sectionName: 'writing', sectionScore: 19 }
				],
				total: 54
			}
		},
		{
			id: 1232,
			user: { name: 'Sergey', id: 1232, englishLevel: EnglishLevels.C1 },
			username: 'Sergey',
			assigner: this.mockAssigner,
			checker: this.mockChecker,
			date: new Date('2020-05-27T04:04:00'),
			level: EnglishLevels.A2,
			score: {
				testSections: [
					{ sectionName: 'grammar', sectionScore: 15 },
					{ sectionName: 'listening', sectionScore: 11 },
					{ sectionName: 'speaking', sectionScore: 9 },
					{ sectionName: 'writing', sectionScore: 19 }
				],
				total: 54
			}
		}
	];
	getTableElements(dataType: string): User[] | PassedTest[] {
		switch (dataType) {
			case 'user':
				return this.USERS_DATA;
			case 'test':
				return this.TESTS_DATA;
			default:
				return [];
		}
	}
}
