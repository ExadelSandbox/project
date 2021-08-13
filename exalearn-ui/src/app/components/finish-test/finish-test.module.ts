import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FinishTestComponent } from './finish-test.component';
import { MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { BrowserModule } from '@angular/platform-browser';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [FinishTestComponent],
	imports: [CommonModule, MatDialogModule, FormsModule, MatButtonModule, BrowserModule, TranslateModule],
	exports: [FinishTestComponent],
	providers: [
		{
			provide: MatDialogRef,
			useValue: {}
		}
	]
})
export class FinishTestModule {}
