import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';

import { TestNavBtnModule } from '../test-nav-btn/test-nav-btn.module';
import { CheckQuestionModule } from '../check-question/check-question.module';
import { CheckGrammarComponent } from './check-grammar.component';

@NgModule({
	declarations: [CheckGrammarComponent],
	imports: [BrowserModule, CheckQuestionModule, TestNavBtnModule, MatButtonModule, MatIconModule],
	exports: [CheckGrammarComponent]
})
export class CheckGrammarModule {}
