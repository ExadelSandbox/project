import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SubmitTestModalComponent } from './submit-test-modal';
import { MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { BrowserModule } from '@angular/platform-browser';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [SubmitTestModalComponent],
	imports: [CommonModule, MatDialogModule, FormsModule, MatButtonModule, BrowserModule, TranslateModule],
	exports: [SubmitTestModalComponent],
	providers: [
		{
			provide: MatDialogRef,
			useValue: {}
		}
	]
})
export class SubmitTestModalModule {}
