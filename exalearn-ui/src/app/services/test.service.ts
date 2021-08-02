import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { API_PATH } from '../constants/api.constants';

@Injectable({
	providedIn: 'root'
})
export class TestService {
	constructor(private apiService: ApiService) {}

	getDataFromBack() {
		return this.apiService.getRequest(API_PATH.TEST).then((response) => response);
	}

	async getGrammarQuestions() {
		const allQuestions = await this.getDataFromBack();
		return allQuestions.grammarQuestion;
	}

	async getAuditionQuestions() {
		const allQuestions = await this.getDataFromBack();
		return allQuestions.auditionQuestion;
	}

	async getEssayTopic() {
		const allQuestions = await this.getDataFromBack();
		return allQuestions.essayTopic;
	}

	async getSpeakingTopic() {
		const allQuestions = await this.getDataFromBack();
		return allQuestions.speakingTopic;
	}
}
