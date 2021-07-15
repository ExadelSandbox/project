import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { QuestionModule } from '../question/question.module';
import { TestGrammarComponent } from './test-grammar.component';
import { TestNavBtnModule } from '../test-nav-btn/test-nav-btn.module';

@NgModule({
	declarations: [TestGrammarComponent],
	imports: [BrowserModule, QuestionModule, TestNavBtnModule],
	providers: [],
	exports: [TestGrammarComponent]
})
export class TestGrammarModule {}
