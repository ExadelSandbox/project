import { EnglishLevels } from '../Enums/enums';

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
}
export interface PassedTest {
	id: number;
	user: User;
	assigner: User;
	checker: User;
	level: EnglishLevels;
	date: Date;
	score: {
		testSections: { sectionName: string; sectionScore: number }[];
		total: number;
	};
}
