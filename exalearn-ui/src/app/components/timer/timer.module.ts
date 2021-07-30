import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TranslateModule } from '@ngx-translate/core';
import { TimerComponent } from './timer.component';
import { TimerService } from '../../services/timer.service';

@NgModule({
	declarations: [TimerComponent],
	imports: [CommonModule, TranslateModule],
	providers: [TimerService],
	exports: [TimerComponent]
})
export class TimerModule {}
