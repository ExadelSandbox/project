import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';

import { CheckNavBtnModule } from '../check-nav-btn/check-nav-btn.module';
import { CheckQuestionModule } from '../check-question/check-question.module';
import { CheckGrammarComponent } from './check-grammar.component';

@NgModule({
	declarations: [CheckGrammarComponent],
	imports: [BrowserModule, CheckQuestionModule, CheckNavBtnModule, MatButtonModule, MatIconModule],
	exports: [CheckGrammarComponent]
})
export class CheckGrammarModule {}
