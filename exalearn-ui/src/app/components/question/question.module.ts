import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from '../../modules/app-routing/app-routing.module';
import { MatButtonModule } from '@angular/material/button';
import { QuestionComponent } from './question.component';
import { MatRadioModule } from '@angular/material/radio';
import { FormsModule } from '@angular/forms';

@NgModule({
	declarations: [QuestionComponent],
	imports: [BrowserModule, AppRoutingModule, FormsModule, MatButtonModule, MatRadioModule],
	providers: [],
	exports: [QuestionComponent]
})
export class QuestionModule {}
