import { NgModule } from '@angular/core';
import { CheckSpeakingComponent } from './check-speaking.component';
import { BrowserModule } from '@angular/platform-browser';
import { MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { TranslateModule } from '@ngx-translate/core';
import { MarkModule } from '../mark/mark.module';
import { CoachPlayerModule } from '../coach-player/coach-player.module';
import { QuestionEditModalModule } from '../question-edit-modal/question-edit-modal.module';

@NgModule({
	declarations: [CheckSpeakingComponent],
	imports: [
		BrowserModule,
		MatDialogModule,
		MatButtonModule,
		TranslateModule,
		MarkModule,
		CoachPlayerModule,
		QuestionEditModalModule
	],
	exports: [CheckSpeakingComponent]
})
export class CheckSpeakingModule {}
