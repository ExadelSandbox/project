import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SubmitTestModal } from './submit-test-modal';
import { MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { BrowserModule } from '@angular/platform-browser';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [SubmitTestModal],
	imports: [CommonModule, MatDialogModule, FormsModule, MatButtonModule, BrowserModule, TranslateModule],
	exports: [SubmitTestModal],
	providers: [
		{
			provide: MatDialogRef,
			useValue: {}
		}
	]
})
export class SubmitTestModalModule {}
