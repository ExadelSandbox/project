import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CheckTestItemPageComponent } from './check-test-item-page.component';
import { MatTabsModule } from '@angular/material/tabs';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { TranslateModule } from '@ngx-translate/core';
import { CheckGrammarModule } from '../../components/check-grammar/check-grammar.module';
import { CheckAuditionModule } from '../../components/check-audition/check-audition.module';
import { CheckEssayModule } from '../../components/check-essay/check-essay.module';

@NgModule({
	declarations: [CheckTestItemPageComponent],
	imports: [
		CommonModule,
		MatTabsModule,
		BrowserAnimationsModule,
		CheckGrammarModule,
		CheckAuditionModule,
		CheckEssayModule,
		TranslateModule
	],
	exports: [CheckTestItemPageComponent]
})
export class CheckTestItemPageModule {}
