import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatRadioModule } from '@angular/material/radio';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { TranslateModule } from '@ngx-translate/core';

import { CheckQuestionComponent } from './check-question.component';
import { MatDialogModule } from '@angular/material/dialog';
import { ReportMessageModalModule } from '../report-message-modal/report-message-modal.module';
import { QuestionEditModalModule } from '../question-edit-modal/question-edit-modal.module';

@NgModule({
	declarations: [CheckQuestionComponent],
	imports: [
		BrowserModule,
		FormsModule,
		MatButtonModule,
		MatRadioModule,
		MatDialogModule,
		TranslateModule,
		ReportMessageModalModule,
		QuestionEditModalModule
	],
	exports: [CheckQuestionComponent]
})
export class CheckQuestionModule {}
