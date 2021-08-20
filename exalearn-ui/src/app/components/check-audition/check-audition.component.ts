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
		this.cloudService.setFiles(
			'https://6a63fca904fd268f15f7-d5770ffdd579eb31eaa89faeffc55fe7.ssl.cf1.rackcdn.com/Audio_zone-Music_in_Manchester.mp3'
		);
	}
}
