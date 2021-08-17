import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { SpeakingComponent } from './speaking.component';
import { TranslateModule } from '@ngx-translate/core';
import { TimerModule } from '../timer/timer.module';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { ToasterModule } from 'angular2-toaster';
import { MatDialogModule } from '@angular/material/dialog';
import { MatIconModule } from '@angular/material/icon';
import { MatTooltipModule } from '@angular/material/tooltip';

@NgModule({
	imports: [
		CommonModule,
		MatButtonModule,
		TranslateModule,
		TimerModule,
		MatProgressSpinnerModule,
		ToasterModule,
		MatDialogModule,
		MatIconModule,
		MatTooltipModule
	],
	declarations: [SpeakingComponent],
	exports: [SpeakingComponent]
})
export class SpeakingModule {}
