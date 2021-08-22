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
	currentIndex = 0;

	constructor(private cloudService: AudioCloudService) {}

	ngOnInit(): void {
		this.cloudService.setListeningUrl(
			'https://firebasestorage.googleapis.com/v0/b/exalearn.appspot.com/o/test%2Fhvn8immdmeg003.mp3?alt=media&token=8b5cd8b2-0ebb-4ad5-a8ff-40c1bb9b7169'
		);
	}
}
