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
import { SpeakingModule } from '../../components/speaking/speaking.module';
import { FooterModule } from '../../components/footer/footer.module';
import { MatIconModule } from '@angular/material/icon';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { LeaveTestModalModule } from '../../components/leave-test-modal/leave-test-modal.module';
import { SubmitTestModalModule } from '../../components/submit-test-modal/submit-test-modal.module';
import { StartCheckTestModule } from '../../components/start-check-test/start-check-test.module';

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
		FinishTestButtonModule,
		SpeakingModule,
		FooterModule,
		MatIconModule,
		SpeakingModule,
		MatProgressSpinnerModule,
		LeaveTestModalModule,
		SubmitTestModalModule,
		StartCheckTestModule
	],
	exports: [TestPageComponent]
})
export class TestPageModule {}
