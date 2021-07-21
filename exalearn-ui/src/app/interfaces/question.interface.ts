export interface Question {
	id: number;
	level: string;
	audioId?: number;
	audioFile?: string;
	type: string;
	text: string;
	description?: string;
	score: number;
	answers?: string[];
}
