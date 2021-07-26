import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FinishTestButtonComponent } from './finish-test-button.component';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [FinishTestButtonComponent],
	imports: [CommonModule, MatIconModule, MatButtonModule, TranslateModule],
	exports: [FinishTestButtonComponent]
})
export class FinishTestButtonModule {}
