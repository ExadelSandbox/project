import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { QuestionModule } from '../question/question.module';
import { TestGrammarComponent } from './test-grammar.component';
import { TestNavBtnModule } from '../test-nav-btn/test-nav-btn.module';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';

@NgModule({
	declarations: [TestGrammarComponent],
	imports: [
		BrowserModule,
		QuestionModule,
		TestNavBtnModule,
		MatButtonModule,
		MatIconModule,
		MatProgressSpinnerModule
	],
	providers: [],
	exports: [TestGrammarComponent]
})
export class TestGrammarModule {}
