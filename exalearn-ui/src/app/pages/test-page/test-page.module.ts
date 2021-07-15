import { NgModule } from '@angular/core';
import { MatTabsModule } from '@angular/material/tabs';

import { TestPageComponent } from './test-page.component';
import { TimerComponent } from '../../components/timer/timer.component';

@NgModule({
	declarations: [TestPageComponent, TimerComponent],
	imports: [MatTabsModule]
})
export class TestPageModule {}
