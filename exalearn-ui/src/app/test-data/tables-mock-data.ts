//TODO: remove test data after back-end integration
import { EnglishLevels } from '../enums/enums';
import { User, Assignment } from '../interfaces/interfaces';

export const mockUser: User = { name: 'John', id: 663, englishLevel: EnglishLevels.B1 };
export const mockAssigner: User = { name: 'Anna', id: 662, englishLevel: EnglishLevels.C1 };
export const mockChecker: User = { name: 'Maximilian', id: 9908, englishLevel: EnglishLevels.C2 };

export const MY_ASSIGNED_DATA: Assignment[] = [
	{
		level: EnglishLevels.B1,
		expire: new Date('2021-09-27T04:04:00'),
		assigner: mockAssigner.name,
		username: mockUser.name,
		passed: 'Passed'
	},
	{
		level: EnglishLevels.B1,
		expire: new Date('2021-10-27T04:04:00'),
		assigner: mockAssigner.name,
		username: mockUser.name,
		passed: 'Not passed'
	},
	{
		level: EnglishLevels.B1,
		expire: new Date('2021-11-27T04:04:00'),
		assigner: mockAssigner.name,
		username: mockUser.name,
		passed: 'Passed'
	}
];

export const MY_QUESTIONS: any = [
	{
		id: 1,
		index: 0,
		levelType: 1,
		question: '♂GET YOU ASS BACK HERE♂',
		questionType: 1,
		answers: [
			{ id: 2, text: 'YES SIR', isCorrect: true },
			{ id: 3, text: 'NO NO NO', isCorrect: false },
			{ id: 4, text: 'FUCK YOU', isCorrect: false },
			{ id: 5, text: 'YEAH', isCorrect: false }
		]
	},
	{
		id: 6,
		index: 0,
		levelType: 2,
		question: '♂GET YOU ASS BACK HERE♂',
		questionType: 1,
		answers: [
			{ id: 7, text: 'YES SIR', isCorrect: true },
			{ id: 8, text: 'NO NO NO', isCorrect: false },
			{ id: 9, text: 'FUCK YOU', isCorrect: false },
			{ id: 10, text: 'YEAH', isCorrect: false }
		]
	},
	{
		id: 11,
		index: 0,
		levelType: 3,
		question: '♂GET YOU ASS BACK HERE♂',
		questionType: 1,
		answers: [
			{ id: 12, text: 'YES SIR', isCorrect: true },
			{ id: 13, text: 'NO NO NO', isCorrect: false },
			{ id: 14, text: 'FUCK YOU', isCorrect: false },
			{ id: 15, text: 'YEAH', isCorrect: false }
		]
	}
];
