import { NgModule } from '@angular/core';
import { MatTabsModule } from '@angular/material/tabs';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { TestPageComponent } from './test-page.component';
import { TimerComponent } from '../../components/timer/timer.component';
import { TestGrammarModule } from '../../components/test-grammar/test-grammar.module';
import { AuditionModule } from '../../components/audition/audition.module';

@NgModule({
	declarations: [TestPageComponent, TimerComponent],
	imports: [MatTabsModule, BrowserAnimationsModule, TestGrammarModule, AuditionModule],
	exports: [TestPageComponent]
})
export class TestPageModule {}
