import { EnglishLevels } from '../enums/enums';

export interface RedirectBtn {
	name: string;
	url: string;
}
export interface Question {
	id: number;
	index: number | undefined;
	audioFile?: AudioFile;
	questionText: string;
	choices?: string[];
	userAnswer: string | null;
}
export interface AudioFile {
	name: string;
	url: string;
}
export interface User {
	name: string;
	id: number;
	englishLevel: EnglishLevels;
}
export interface PassedTest {
	id: number;
	user: User;
	username: string;
	assigner: User;
	checker: User;
	level: EnglishLevels;
	date: Date;
	sectionScore: {
		testSections: { sectionName: string; sectionScore: number }[];
	};
	totalScore: number;
}
