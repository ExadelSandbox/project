import { NgModule } from '@angular/core';
import { CheckSpeakingComponent } from './check-speaking.component';
import { BrowserModule } from '@angular/platform-browser';
import { MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { TranslateModule } from '@ngx-translate/core';
import { MarkModule } from '../mark/mark.module';
import { CoachPlayerModule } from '../coach-player/coach-player.module';

@NgModule({
	declarations: [CheckSpeakingComponent],
	imports: [BrowserModule, MatDialogModule, MatButtonModule, TranslateModule, MarkModule, CoachPlayerModule],
	exports: [CheckSpeakingComponent]
})
export class CheckSpeakingModule {}
