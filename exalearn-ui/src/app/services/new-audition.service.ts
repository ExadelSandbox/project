import { Injectable } from '@angular/core';
import { Answer, NewListeningServer, Exercise, NewListeningForm } from '../interfaces/new-content-interface';

@Injectable({
	providedIn: 'root'
})
export class NewAuditionService {
	private exercises: Exercise[];
	private url: string;
	private levelType: number;
	private result: NewListeningServer[] = [];

	private getData(data: NewListeningForm): void {
		this.exercises = data.exercises;
		this.url = data.url;
		this.levelType = data.levelType;
	}

	private configureResult(): void {
		this.exercises.forEach((item: Exercise) => {
			this.result.push(new NewAudition(this.url, item.question, this.levelType, item.answers));
		});
	}

	transformData(data: NewListeningForm): NewListeningServer[] {
		this.result = [];
		this.getData(data);
		this.configureResult();
		return this.result;
	}
}

export class NewAudition implements NewListeningServer {
	levelType: number;
	questionType = 2;
	url: string;
	question: string;
	answers: Answer[];
	constructor(url: string, question: string, levelType: number, answers: Answer[]) {
		this.levelType = levelType;
		this.url = url;
		this.question = question;
		this.answers = answers;
	}
}
