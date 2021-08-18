//TODO: current user interface is a temporary decision and should be replaced
// by userBack interface after mock data removal
//TODO: remove sectionScore from passed test interface
import { EnglishLevels } from '../enums/enums';

export interface RedirectBtn {
	name: string;
	url: string;
}

export interface Question {
	id: number;
	index: number | undefined;
	question: Question[];
	answers?: Question[];
	url?: string;
	levelType: number;
	questionType: number;
	userAnswer: string | null;
	text: string;
	audioFile?: AudioFile;
	isCorrect: boolean;
}

export interface testAnswer {
	id?: number;
	passedTestId?: number;
	questionId?: number;
	answer?: testAnswer | undefined | string;
	fileUrl?: string;
	assessment?: number;
	reportId: number | null;
	reportedMessage?: string | null;
	url?: string;
}

export interface Test {
	auditionQuestion: Question[];
	grammarQuestion: Question[];
	passedTestId: number;
	topicQuestion: topicQuestion[];
}

export interface topicQuestion {
	id: number;
	questionType: number;
	topic: string;
}

export interface Answer {
	id: number;
	userAnswer: string | null;
}

export interface CheckQuestion {
	id: number;
	index: number | undefined;
	audioFile?: AudioFile;
	questionText: string;
	choices?: string[];
	userAnswer: string | null;
	rightAnswer: string;
	reportComment?: string;
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
	roleName: string;
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
	assigner: string;
}

export interface CheckCoachTest {
	id: number;
	level: EnglishLevels;
	date: Date;
	username: string;
	totalScore: number;
}

export interface Topic {
	id: number;
	questionType: number;
	topic: string;
}

export interface PassedTest {
	$id: number;
	username: string;
	level: EnglishLevels;
	date: Date;
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
