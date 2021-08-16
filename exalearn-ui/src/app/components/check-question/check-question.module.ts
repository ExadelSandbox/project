import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatRadioModule } from '@angular/material/radio';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { TranslateModule } from '@ngx-translate/core';

import { CheckQuestionComponent } from './check-question.component';

@NgModule({
	declarations: [CheckQuestionComponent],
	imports: [BrowserModule, FormsModule, MatButtonModule, MatRadioModule, TranslateModule],
	exports: [CheckQuestionComponent]
})
export class CheckQuestionModule {}
