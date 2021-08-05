import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { BrowserModule } from '@angular/platform-browser';
import { TranslateModule } from '@ngx-translate/core';
import { LeaveTestModalComponent } from './leave-test-modal.component';

@NgModule({
	declarations: [LeaveTestModalComponent],
	imports: [CommonModule, MatDialogModule, FormsModule, MatButtonModule, BrowserModule, TranslateModule],
	exports: [LeaveTestModalComponent],
	providers: [
		{
			provide: MatDialogRef,
			useValue: {}
		}
	]
})
export class LeaveTestModalModule {}
