import { NgModule } from '@angular/core';
import { MatTabsModule } from '@angular/material/tabs';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { TestPageComponent } from './test-page.component';
import { TimerComponent } from '../../components/timer/timer.component';

@NgModule({
	declarations: [TestPageComponent, TimerComponent],
	imports: [MatTabsModule, BrowserAnimationsModule],
	exports: [TestPageComponent]
})
export class TestPageModule {}
