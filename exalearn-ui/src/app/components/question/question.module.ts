import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { MatButtonModule } from '@angular/material/button';
import { QuestionComponent } from './question.component';
import { MatRadioModule } from '@angular/material/radio';
import { FormsModule } from '@angular/forms';
import { MatIconModule } from '@angular/material/icon';
import { MatTooltipModule } from '@angular/material/tooltip';
import { MatDialogModule } from '@angular/material/dialog';
import { ReportQuestionModalModule } from '../report-question-modal/report-question-modal.module';

@NgModule({
	declarations: [QuestionComponent],
	imports: [
		BrowserModule,
		FormsModule,
		MatButtonModule,
		MatRadioModule,
		MatIconModule,
		MatTooltipModule,
		MatDialogModule,
		ReportQuestionModalModule
	],
	providers: [],
	exports: [QuestionComponent]
})
export class QuestionModule {}
