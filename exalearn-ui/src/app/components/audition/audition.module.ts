import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from '../../modules/app-routing/app-routing.module';
import { MatButtonModule } from '@angular/material/button';
import { MatTabsModule } from '@angular/material/tabs';
import { MatStepperModule } from '@angular/material/stepper';
import { MatIconModule } from '@angular/material/icon';
import { AuditionComponent } from './audition.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSliderModule } from '@angular/material/slider';
import { QuestionModule } from '../question/question.module';
import { FormsModule } from '@angular/forms';

@NgModule({
	declarations: [AuditionComponent],
	imports: [
		BrowserModule,
		AppRoutingModule,
		FormsModule,
		MatButtonModule,
		MatTabsModule,
		MatStepperModule,
		MatIconModule,
		MatToolbarModule,
		MatSliderModule,
		QuestionModule
	],
	providers: [],
	exports: [AuditionComponent]
})
export class AuditionModule {}
