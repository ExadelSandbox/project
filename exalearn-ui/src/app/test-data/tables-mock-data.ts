//TODO: remove test data after back-end integration
import { EnglishLevels } from '../enums/enums';
import { User, Assignment } from '../interfaces/interfaces';

export const mockUser: User = { name: 'John', id: 663, englishLevel: EnglishLevels.B1 };
export const mockAssigner: User = { name: 'Anna', id: 662, englishLevel: EnglishLevels.C1 };
export const mockChecker: User = { name: 'Maximilian', id: 9908, englishLevel: EnglishLevels.C2 };

export const USERS_DATA: User[] = [
	{ name: 'Semen', id: 12312, englishLevel: EnglishLevels.B1 },
	{ name: 'Kristie', id: 1562, englishLevel: EnglishLevels.B1 },
	{ name: 'Danya', id: 1292, englishLevel: EnglishLevels.C1 },
	{ name: 'Polina', id: 9912, englishLevel: EnglishLevels.A2 },
	{ name: 'Anna', id: 7202, englishLevel: EnglishLevels.C2 }
];

export const MY_ASSIGNED_DATA: Assignment[] = [
	{
		level: 'B1',
		expire: new Date('2021-09-27T04:04:00'),
		assigner: mockAssigner.name,
		username: mockUser.name,
		passed: 'Passed'
	},
	{
		level: 'B2',
		expire: new Date('2021-10-27T04:04:00'),
		assigner: mockAssigner.name,
		username: mockUser.name,
		passed: 'Not passed'
	},
	{
		level: 'C1',
		expire: new Date('2021-11-27T04:04:00'),
		assigner: mockAssigner.name,
		username: mockUser.name,
		passed: 'Passed'
	}
];
export const MY_ASSIGNMENTS_DATA: Assignment[] = [
	{
		level: 'B1',
		expire: new Date('2021-09-27T04:04:00'),
		assigner: mockAssigner.name,
		username: mockUser.name,
		passed: 'Passed'
	},
	{
		level: 'B2',
		expire: new Date('2021-10-27T04:04:00'),
		assigner: mockAssigner.name,
		username: mockUser.name,
		passed: 'Not passed'
	},
	{
		level: 'C1',
		expire: new Date('2021-11-27T04:04:00'),
		assigner: mockAssigner.name,
		username: mockUser.name,
		passed: 'Passed'
	}
];
