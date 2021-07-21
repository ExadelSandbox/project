export interface Question {
	id: number;
	level: string;
	audioId?: number | null;
	audioFile?: string | null;
	type: string;
	text: string;
	description?: string;
	score: number;
	answers?: string[] | null;
}
