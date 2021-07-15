import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatButtonModule } from '@angular/material/button';

import { MainPageComponent } from './main-page.component';
import { HeaderComponent } from '../../components/header/header.component';
import { FooterComponent } from '../../components/footer/footer.component';
import { TestGrammarModule } from '../../components/test-grammar/test-grammar.module';
import { AuditionModule } from '../../components/audition/audition.module';

@NgModule({
	declarations: [MainPageComponent, HeaderComponent, FooterComponent],
	imports: [BrowserModule, MatButtonModule, TestGrammarModule, AuditionModule],
	providers: [],
	bootstrap: []
})
export class MainPageModule {}
