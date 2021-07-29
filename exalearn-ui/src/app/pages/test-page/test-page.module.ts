import { NgModule } from '@angular/core';
import { MatTabsModule } from '@angular/material/tabs';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { TestPageComponent } from './test-page.component';
import { TestGrammarModule } from '../../components/test-grammar/test-grammar.module';
import { AuditionModule } from '../../components/audition/audition.module';
import { TranslateModule } from '@ngx-translate/core';
import { EssayPartModule } from '../../components/essay-part/essay-part.module';
import { TimerModule } from '../../components/timer/timer.module';
import { FinishTestButtonModule } from '../../components/finish-test-button/finish-test-button.module';

@NgModule({
	declarations: [TestPageComponent],
	imports: [
		MatTabsModule,
		BrowserAnimationsModule,
		TestGrammarModule,
		AuditionModule,
		EssayPartModule,
		TranslateModule,
		TimerModule,
		FinishTestButtonModule
	],
	exports: [TestPageComponent]
})
export class TestPageModule {}
