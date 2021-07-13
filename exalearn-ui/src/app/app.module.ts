import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './modules/app-routing/app-routing.module';
import { AppComponent } from './app.component';
import { MainPageComponent } from './pages/main-page/main-page.component';
import { MatButtonModule } from '@angular/material/button';
import { TestGrammarModuleComponent } from './components/test-grammar-module/test-grammar-module.component';
import { MatStepperModule } from '@angular/material/stepper';
import { FormsModule } from '@angular/forms';
import { MatRadioModule } from '@angular/material/radio';
import { QuestionComponent } from './components/question/question.component';

@NgModule({
	declarations: [AppComponent, MainPageComponent, TestGrammarModuleComponent, QuestionComponent],
	imports: [BrowserModule, AppRoutingModule, MatButtonModule, MatStepperModule, FormsModule, MatRadioModule],
	providers: [],
	bootstrap: [AppComponent]
})
export class AppModule {}
