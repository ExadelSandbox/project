import { Injectable } from '@angular/core';
import { Question } from '../interfaces/question.interface';
import { QUESTIONS } from '../test-data/mock-questions';

@Injectable({
	providedIn: 'root'
})
export class TestsService {
	allQuestions = QUESTIONS;

	getTestsFromBack() {}

	getGrammarQuestions(level: string) {
		const filteredQuestions = this.filterQuestions(level, 'grammar');
		const grammarQuestions = [];

		while (grammarQuestions.length < 10) {
			const randomQuestion = this.getRandomQuestion(filteredQuestions);
			if (!this.hasThisQuestion(grammarQuestions, randomQuestion)) {
				grammarQuestions.push(randomQuestion);
			}
		}

		return grammarQuestions;
	}

	getListeningQuestions(level: string) {
		const filteredQuestions = this.filterQuestions(level, 'listening');
		const listeningQuestions = this.getRandomQuestion(filteredQuestions);

		return listeningQuestions;
	}

	getEssayQuestion(level: string) {
		const filteredQuestions = this.filterQuestions(level, 'essay');
		const essayQuestion = this.getRandomQuestion(filteredQuestions);

		return essayQuestion;
	}

	getSpeakingQuestion(level: string) {
		const filteredQuestions = this.filterQuestions(level, 'speaking');
		const speakingQuestion = this.getRandomQuestion(filteredQuestions);

		return speakingQuestion;
	}

	hasThisQuestion(arrQuestions: Question[], question: Question) {
		return arrQuestions.map((q) => q.id).indexOf(question.id) > -1;
	}

	getRandomQuestion(arrQuestions: Question[]) {
		const randomIndex = Math.floor(arrQuestions.length * Math.random());

		return arrQuestions[randomIndex];
	}

	filterQuestions(level: string, questionType: string) {
		const sortedQuestions = this.allQuestions.filter((q) => q.level === level && q.type === questionType);

		return sortedQuestions;
	}

	constructor() {}
}
