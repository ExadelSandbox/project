import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DraftCheckedTestButtonComponent } from './draft-checked-test-button.component';

import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [DraftCheckedTestButtonComponent],
	imports: [CommonModule, MatIconModule, MatButtonModule, TranslateModule],
	exports: [DraftCheckedTestButtonComponent],
	providers: []
})
export class DraftCheckedTestButtonModule {}
