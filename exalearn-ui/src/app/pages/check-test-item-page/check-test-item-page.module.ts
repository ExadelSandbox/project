import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CheckTestItemPageComponent } from './check-test-item-page.component';
import { MatTabsModule } from '@angular/material/tabs';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { TestGrammarModule } from '../../components/test-grammar/test-grammar.module';
import { AuditionModule } from '../../components/audition/audition.module';
import { EssayPartModule } from '../../components/essay-part/essay-part.module';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [CheckTestItemPageComponent],
	imports: [
		CommonModule,
		MatTabsModule,
		BrowserAnimationsModule,
		TestGrammarModule,
		AuditionModule,
		EssayPartModule,
		TranslateModule
	],
	exports: [CheckTestItemPageComponent]
})
export class CheckTestItemPageModule {}
