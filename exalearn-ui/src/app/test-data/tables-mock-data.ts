//TODO: remove test data after back-end integration
import { EnglishLevels } from '../enums/enums';
import { PassedTest, User, Assignment } from '../interfaces/interfaces';

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

export const ALL_TESTS_DATA: PassedTest[] = [
	//   {
	// 		id: 122,
	// 		user: { name: 'Dennis', id: 122, englishLevel: EnglishLevels.C1 },
	// 		username: 'Dennis',
	// 		assigner: mockAssigner,
	// 		checker: mockChecker,
	// 		date: new Date('2020-05-27T04:04:00'),
	// 		level: EnglishLevels.B1,
	// 		sectionScore: {
	// 			testSections: [
	// 				{ sectionName: 'grammar', sectionScore: 15 },
	// 				{ sectionName: 'listening', sectionScore: 11 },
	// 				{ sectionName: 'speaking', sectionScore: 9 },
	// 				{ sectionName: 'writing', sectionScore: 19 }
	// 			]
	// 		},
	// 		totalScore: 54
	// 	},
	//   {
	//     id: 12,
	//     user: { name: 'Dima', id: 12, englishLevel: EnglishLevels.B2 },
	//     username: 'Dima',
	//     assigner: mockAssigner,
	//     checker: mockChecker,
	//     date: new Date('2021-05-17T04:24:00'),
	//     level: EnglishLevels.B2,
	//     sectionScore: {
	//       testSections: [
	//         { sectionName: 'grammar', sectionScore: 17 },
	//         { sectionName: 'listening', sectionScore: 19 },
	//         { sectionName: 'speaking', sectionScore: 19 },
	//         { sectionName: 'writing', sectionScore: 19 }
	//       ]
	//     },
	//     totalScore: 74
	//   },
	//   {
	// 		id: 1232,
	// 		user: { name: 'Sergey', id: 1232, englishLevel: EnglishLevels.C1 },
	// 		username: 'Sergey',
	// 		assigner: mockAssigner,
	// 		checker: mockChecker,
	// 		date: new Date('2020-05-27T04:04:00'),
	// 		level: EnglishLevels.A2,
	// 		sectionScore: {
	// 			testSections: [
	// 				{ sectionName: 'grammar', sectionScore: 15 },
	// 				{ sectionName: 'listening', sectionScore: 11 },
	// 				{ sectionName: 'speaking', sectionScore: 9 },
	// 				{ sectionName: 'writing', sectionScore: 19 }
	// 			]
	// 		},
	// 		totalScore: 54
	// 	}
];

export const MY_TESTS_DATA: PassedTest[] = [
	// {
	// 	id: 12,
	// 	user: { name: 'Dima', id: 12, englishLevel: EnglishLevels.B2 },
	// 	username: 'Dima',
	// 	assigner: mockAssigner,
	// 	checker: mockChecker,
	// 	date: new Date('2021-05-17T04:24:00'),
	// 	level: EnglishLevels.B2,
	// 	sectionScore: {
	// 		testSections: [
	// 			{ sectionName: 'grammar', sectionScore: 7 },
	// 			{ sectionName: 'listening', sectionScore: 9 },
	// 			{ sectionName: 'speaking', sectionScore: 9 },
	// 			{ sectionName: 'writing', sectionScore: 9 }
	// 		]
	// 	},
	// 	totalScore: 34
	// },
	// {
	// 	id: 122,
	// 	user: { name: 'Dima', id: 12, englishLevel: EnglishLevels.B2 },
	// 	username: 'Dima',
	// 	assigner: mockAssigner,
	// 	checker: mockChecker,
	// 	date: new Date('2020-05-27T04:04:00'),
	// 	level: EnglishLevels.B1,
	// 	sectionScore: {
	// 		testSections: [
	// 			{ sectionName: 'grammar', sectionScore: 5 },
	// 			{ sectionName: 'listening', sectionScore: 1 },
	// 			{ sectionName: 'speaking', sectionScore: 9 },
	// 			{ sectionName: 'writing', sectionScore: 9 }
	// 		]
	// 	},
	// 	totalScore: 24
	// },
	// {
	// 	id: 1232,
	// 	user: { name: 'Dima', id: 12, englishLevel: EnglishLevels.B2 },
	// 	username: 'Dima',
	// 	assigner: mockAssigner,
	// 	checker: mockChecker,
	// 	date: new Date('2020-05-27T04:04:00'),
	// 	level: EnglishLevels.A2,
	// 	sectionScore: {
	// 		testSections: [
	// 			{ sectionName: 'grammar', sectionScore: 5 },
	// 			{ sectionName: 'listening', sectionScore: 1 },
	// 			{ sectionName: 'speaking', sectionScore: 9 },
	// 			{ sectionName: 'writing', sectionScore: 9 }
	// 		]
	// 	},
	// 	totalScore: 24
	// },
	// {
	// 	id: 12,
	// 	user: { name: 'Dima', id: 12, englishLevel: EnglishLevels.B2 },
	// 	username: 'Dima',
	// 	assigner: mockAssigner,
	// 	checker: mockChecker,
	// 	date: new Date('2021-05-17T04:24:00'),
	// 	level: EnglishLevels.B2,
	// 	sectionScore: {
	// 		testSections: [
	// 			{ sectionName: 'grammar', sectionScore: 9 },
	// 			{ sectionName: 'listening', sectionScore: 9 },
	// 			{ sectionName: 'speaking', sectionScore: 9 },
	// 			{ sectionName: 'writing', sectionScore: 9 }
	// 		]
	// 	},
	// 	totalScore: 36
	// }
];

export const MY_ASSIGNED_DATA: Assignment[] = [
	{
		level: EnglishLevels.B1,
		expire: new Date('2021-09-27T04:04:00'),
		assigner: mockAssigner.name,
		username: mockUser.name,
		passed: 'Passed'
	},
	{
		level: EnglishLevels.B2,
		expire: new Date('2021-10-27T04:04:00'),
		assigner: mockAssigner.name,
		username: mockUser.name,
		passed: 'Not passed'
	},
	{
		level: EnglishLevels.C1,
		expire: new Date('2021-11-27T04:04:00'),
		assigner: mockAssigner.name,
		username: mockUser.name,
		passed: 'Passed'
	}
];
export const MY_ASSIGNMENTS_DATA: Assignment[] = [
	{
		level: EnglishLevels.B1,
		expire: new Date('2021-09-27T04:04:00'),
		assigner: mockAssigner.name,
		username: mockUser.name,
		passed: 'Passed'
	},
	{
		level: EnglishLevels.B2,
		expire: new Date('2021-10-27T04:04:00'),
		assigner: mockAssigner.name,
		username: mockUser.name,
		passed: 'Not passed'
	},
	{
		level: EnglishLevels.C1,
		expire: new Date('2021-11-27T04:04:00'),
		assigner: mockAssigner.name,
		username: mockUser.name,
		passed: 'Passed'
	}
];
