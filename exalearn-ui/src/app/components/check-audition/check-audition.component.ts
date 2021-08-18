import { Component, Input, OnInit } from '@angular/core';
import { AudioCloudService } from '../../services/audio-cloud.service';
import { CheckQuestion, Question } from 'src/app/interfaces/interfaces';
import { checkQuestions } from '../../test-data/test-questions';

@Component({
	selector: 'app-check-audition',
	templateUrl: './check-audition.component.html',
	styleUrls: ['./check-audition.component.scss']
})
export class CheckAuditionComponent implements OnInit {
	@Input() checkQuestions: CheckQuestion[];
	@Input() questionsAudio: Question[];
	currentIndex = 0;
	testQuestionsAudit: CheckQuestion[] = [];

	constructor(private cloudService: AudioCloudService) {}

	ngOnInit(): void {
		this.testQuestionsAudit = checkQuestions;
		this.cloudService.setFiles(
			'https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3'
		);
	}
}
