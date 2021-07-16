import { NgModule } from '@angular/core';
import { MatTabsModule } from '@angular/material/tabs';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatInputModule } from '@angular/material/input';

import { TestPageComponent } from './test-page.component';
import { TimerComponent } from '../../components/timer/timer.component';
import { EssayPartComponent } from '../../components/essay-part/essay-part.component';
import { TestGrammarModule } from '../../components/test-grammar/test-grammar.module';

@NgModule({
	declarations: [TestPageComponent, EssayPartComponent, TimerComponent],
	imports: [MatTabsModule, BrowserAnimationsModule, MatInputModule, TestGrammarModule],
	exports: [TestPageComponent]
})
export class TestPageModule {}
