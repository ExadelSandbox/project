export interface RedirectBtn {
	name: string;
	url: string;
}
export interface Question {
	id: number;
	index: number | undefined;
	audioFile?: AudioFile;
	questionText: string;
	choices?: [string, string, string, string];
	userAnswer: string | null;
}
export interface AudioFile {
	name: string;
	url: string;
}
