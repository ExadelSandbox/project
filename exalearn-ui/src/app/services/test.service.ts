import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { API_PATH } from '../constants/api.constants';

@Injectable({
	providedIn: 'root'
})
export class TestService {
	public generatedQuestions: any;

	constructor(private apiService: ApiService) {}

	async getDataFromBack() {
		this.generatedQuestions = await this.apiService.getRequest(API_PATH.TEST).then((response) => response);
		return this.generatedQuestions;
	}

	async getGrammarQuestions() {
		return this.generatedQuestions.grammarQuestion;
	}

	async getAuditionQuestions() {
		return this.generatedQuestions.auditionQuestion;
	}

	async getEssayTopic() {
		return this.generatedQuestions.essayTopic;
	}

	async getSpeakingTopic() {
		return this.generatedQuestions.speakingTopic;
	}
}
