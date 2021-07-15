import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatButtonModule } from '@angular/material/button';

import { MainPageComponent } from './main-page.component';
import { HeaderComponent } from '../../components/header/header.component';
import { FooterComponent } from '../../components/footer/footer.component';
import { TestGrammarModule } from '../../components/test-grammar/test-grammar.module';

@NgModule({
	declarations: [MainPageComponent, HeaderComponent, FooterComponent],
	imports: [BrowserModule, MatButtonModule, TestGrammarModule],
	providers: [],
	bootstrap: []
})
export class MainPageModule {}
