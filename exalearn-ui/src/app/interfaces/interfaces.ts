//TODO: current user interface is a temporary decision and should be replaced
// by userBack interface after mock data removal
import { EnglishLevels } from '../enums/enums';

export interface RedirectBtn {
	name: string;
	url: string;
}

export interface Question {
	id: number | any;
	index: number | undefined;
	audioFile?: AudioFile;
	question: string | any;
	answers?: string[] | any;
	userAnswer: string | any | null;
	url?: string;
}

export interface testAnswer {
	id?: number | any;
	passedTestId?: number | any;
	questionId?: number | string | any;
	answer?: any;
	fileUrl?: string | any;
	assessment?: 0 | any;
}

export interface Answer {
	id: number;
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
export interface UserBack extends User {
	email: string;
	firstName: string;
	lastName: string;
	fullName: string;
	isActive: boolean;
	roleName: string | null;
}

export interface UserAuth {
	username: string;
	password: string;
}

export interface Assignment {
	username: string;
	assigner: string;
	level: EnglishLevels;
	expire: Date;
	passed: string;
}

export interface MyAssigned {
	id: number;
	level: EnglishLevels;
	expireDate: Date;
	assignedBy: string;
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

export interface serverAuthResponse {
	token: string;
}

export function isUser(el: PassedTest | UserBack): el is UserBack {
	return (el as UserBack).firstName !== undefined && (el as UserBack).lastName !== undefined;
}
export function isPassedTest(el: PassedTest | UserBack): el is PassedTest {
	return (
		(el as PassedTest).username !== undefined &&
		(el as PassedTest).level !== undefined &&
		(el as PassedTest).date !== undefined
	);
}
