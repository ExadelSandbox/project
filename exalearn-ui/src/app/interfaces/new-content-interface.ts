export interface Answer {
	text: string;
	isCorrect: boolean;
}

export interface NewListeningServer {
	levelType: number;
	url: string;
	question: string;
	answers: Answer[];
}
export interface Exercise {
	question: string;
	answers: Answer[];
}

export interface NewListeningForm {
	levelType: number;
	url: string;
	exercises: Exercise[];
}
