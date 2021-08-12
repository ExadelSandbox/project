import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { SpeakingComponent } from './speaking.component';
import { TranslateModule } from '@ngx-translate/core';
import { TimerModule } from '../timer/timer.module';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { ToasterModule } from 'angular2-toaster';

@NgModule({
	imports: [CommonModule, MatButtonModule, TranslateModule, TimerModule, MatProgressSpinnerModule, ToasterModule],
	declarations: [SpeakingComponent],
	exports: [SpeakingComponent]
})
export class SpeakingModule {}
