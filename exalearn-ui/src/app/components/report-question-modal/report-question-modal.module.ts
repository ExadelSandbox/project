import { NgModule } from '@angular/core';
import { ReportQuestionModalComponent } from './report-question-modal.component';
import { MatInputModule } from '@angular/material/input';
import { BrowserModule } from '@angular/platform-browser';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatButtonModule } from '@angular/material/button';
import { TranslateModule } from '@ngx-translate/core';
import { ReactiveFormsModule } from '@angular/forms';
import { MatDialogModule } from '@angular/material/dialog';

@NgModule({
	declarations: [ReportQuestionModalComponent],
	imports: [
		BrowserModule,
		MatInputModule,
		MatFormFieldModule,
		MatButtonModule,
		TranslateModule,
		ReactiveFormsModule,
		MatDialogModule
	]
})
export class ReportQuestionModalModule {}
