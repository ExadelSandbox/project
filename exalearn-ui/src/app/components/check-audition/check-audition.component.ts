import { Component, Input, OnInit } from '@angular/core';

import { CheckCoachQuestion, Question } from 'src/app/interfaces/interfaces';
import { AudioCloudService } from '../../services/audio-cloud.service';

@Component({
	selector: 'app-check-audition',
	templateUrl: './check-audition.component.html',
	styleUrls: ['./check-audition.component.scss']
})
export class CheckAuditionComponent implements OnInit {
	@Input() testAuditionAnswers: CheckCoachQuestion[];
	@Input() questionsAudio: Question[];
	@Input() testTopicAnswers: CheckCoachQuestion;
	currentIndex = 0;

	constructor(private cloudService: AudioCloudService) {}

	ngOnInit(): void {
		this.cloudService.setListeningUrl(this.testAuditionAnswers[0].fileUrl);
	}
}
