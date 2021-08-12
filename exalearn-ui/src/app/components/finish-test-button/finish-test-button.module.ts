import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FinishTestButtonComponent } from './finish-test-button.component';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { TranslateModule } from '@ngx-translate/core';
import { FinishTestModalModule } from '../finish-test-modal/finish-test-modal.module';
import { TimerComponent } from '../timer/timer.component';

@NgModule({
	declarations: [FinishTestButtonComponent],
	imports: [CommonModule, MatIconModule, MatButtonModule, TranslateModule, FinishTestModalModule],
	exports: [FinishTestButtonComponent],
	providers: [TimerComponent]
})
export class FinishTestButtonModule {}
