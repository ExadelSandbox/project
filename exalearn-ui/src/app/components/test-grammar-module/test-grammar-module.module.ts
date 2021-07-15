import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from '../../modules/app-routing/app-routing.module';
import { MatButtonModule } from '@angular/material/button';
import { TestGrammarModuleComponent } from './test-grammar-module.component';
import { QuestionModule } from '../question/question.module';

@NgModule({
	declarations: [TestGrammarModuleComponent],
	imports: [BrowserModule, AppRoutingModule, MatButtonModule, QuestionModule],
	providers: [],
	exports: [TestGrammarModuleComponent]
})
export class TestGrammarModule {}
