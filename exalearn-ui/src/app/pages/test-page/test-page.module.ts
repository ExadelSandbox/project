import { NgModule } from '@angular/core';
import { MatTabsModule } from '@angular/material/tabs';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { TestPageComponent } from './test-page.component';
import { TimerComponent } from '../../components/timer/timer.component';
import { TestGrammarModule } from '../../components/test-grammar/test-grammar.module';
import { AuditionModule } from '../../components/audition/audition.module';
import { EssayPartComponent } from '../../components/essay-part/essay-part.component';
import { TranslateModule } from '@ngx-translate/core';
import { EssayPartModule } from '../../components/essay-part/essay-part.module';

@NgModule({
	declarations: [TestPageComponent, TimerComponent],
	imports: [MatTabsModule, BrowserAnimationsModule, TestGrammarModule, EssayPartModule, AuditionModule],
	declarations: [TestPageComponent, EssayPartComponent, TimerComponent],
	imports: [
		MatTabsModule,
		BrowserAnimationsModule,
		TestGrammarModule,
		MatInputModule,
		AuditionModule,
		TranslateModule
	],
	exports: [TestPageComponent]
})
export class TestPageModule {}
