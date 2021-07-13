export interface RedirectBtn {
	name: string;
	url: string;
}
export interface Question {
	questionText: string;
	choices: [string, string, string, string];
	selectedAnswer: string | null;
}
