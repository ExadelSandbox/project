import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { SpeakingComponent } from './speaking.component';
import { TimerModule } from '../timer/timer.module';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	imports: [CommonModule, MatButtonModule, TimerModule, TranslateModule],
	declarations: [SpeakingComponent],
	exports: [SpeakingComponent]
})
export class SpeakingModule {}
