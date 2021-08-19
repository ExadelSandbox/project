import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CheckTestItemPageComponent } from './check-test-item-page.component';
import { MatTabsModule } from '@angular/material/tabs';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { TranslateModule } from '@ngx-translate/core';
import { CheckGrammarModule } from '../../components/check-grammar/check-grammar.module';
import { CheckAuditionModule } from '../../components/check-audition/check-audition.module';
import { CheckEssayModule } from '../../components/check-essay/check-essay.module';
import { SubmitCheckedTestButtonModule } from '../../components/submit-checked-test-button/submit-checked-test-button.module';
import { DraftCheckedTestButtonModule } from '../../components/draft-checked-test-button/draft-checked-test-button.module';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { CheckSpeakingModule } from '../../components/check-speaking/check-speaking.module';

@NgModule({
	declarations: [CheckTestItemPageComponent],
	imports: [
		CommonModule,
		MatTabsModule,
		BrowserAnimationsModule,
		CheckGrammarModule,
		CheckAuditionModule,
		CheckEssayModule,
		CheckSpeakingModule,
		TranslateModule,
		SubmitCheckedTestButtonModule,
		MatProgressSpinnerModule,
		DraftCheckedTestButtonModule
	],
	exports: [CheckTestItemPageComponent]
})
export class CheckTestItemPageModule {}
