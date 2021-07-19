import { NgModule } from '@angular/core';
import { MatTabsModule } from '@angular/material/tabs';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatInputModule } from '@angular/material/input';

import { TestPageComponent } from './test-page.component';
import { TimerComponent } from '../../components/timer/timer.component';
import { TestGrammarModule } from '../../components/test-grammar/test-grammar.module';
import { AuditionModule } from '../../components/audition/audition.module';
import { EssayPartComponent } from '../../components/essay-part/essay-part.component';

@NgModule({
	declarations: [TestPageComponent, EssayPartComponent, TimerComponent],
	imports: [MatTabsModule, BrowserAnimationsModule, TestGrammarModule, MatInputModule, AuditionModule],
	exports: [TestPageComponent]
})
export class TestPageModule {}
