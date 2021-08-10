import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';

import { QuestionModule } from '../question/question.module';
import { TestNavBtnModule } from '../test-nav-btn/test-nav-btn.module';
import { CheckGrammarComponent } from './check-grammar.component';

@NgModule({
	declarations: [CheckGrammarComponent],
	imports: [BrowserModule, QuestionModule, TestNavBtnModule, MatButtonModule, MatIconModule],
	exports: [CheckGrammarComponent]
})
export class CheckGrammarModule {}
