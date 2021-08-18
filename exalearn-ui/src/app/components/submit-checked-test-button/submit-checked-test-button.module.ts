import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SubmitCheckedTestButtonComponent } from './submit-checked-test-button.component';

import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [SubmitCheckedTestButtonComponent],
	imports: [CommonModule, MatIconModule, MatButtonModule, TranslateModule],
	exports: [SubmitCheckedTestButtonComponent],
	providers: []
})
export class SubmitCheckedTestButtonModule {}
