import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './modules/app-routing/app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';

import { AuditionModule } from './components/audition/audition.module';
import { MainPageModule } from './pages/main-page/main-page.module';
import { TestGrammarModule } from './components/test-grammar-module/test-grammar-module.module';
import { QuestionModule } from './components/question/question.module';

@NgModule({
	declarations: [AppComponent],
	imports: [
		BrowserModule,
		AppRoutingModule,
		FormsModule,
		AuditionModule,
		MainPageModule,
		TestGrammarModule,
		QuestionModule
	],
	providers: [],
	exports: [],
	bootstrap: [AppComponent]
})
export class AppModule {}
