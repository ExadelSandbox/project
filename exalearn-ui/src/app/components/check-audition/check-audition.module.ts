import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';

import { CheckAuditionComponent } from './check-audition.component';
import { CheckQuestionModule } from '../check-question/check-question.module';
import { CheckNavBtnModule } from '../check-nav-btn/check-nav-btn.module';
import { AudioPlayerModule } from '../audio-player/audio-player.module';
import { CoachPlayerModule } from '../coach-player/coach-player.module';

@NgModule({
	declarations: [CheckAuditionComponent],
	imports: [
		BrowserModule,
		AudioPlayerModule,
		CheckQuestionModule,
		CheckNavBtnModule,
		MatButtonModule,
		MatIconModule,
		CoachPlayerModule
	],
	exports: [CheckAuditionComponent]
})
export class CheckAuditionModule {}
