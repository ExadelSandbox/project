import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StartCheckTestComponent } from './start-check-test.component';
import { MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { BrowserModule } from '@angular/platform-browser';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [StartCheckTestComponent],
	imports: [CommonModule, MatDialogModule, FormsModule, MatButtonModule, BrowserModule, TranslateModule],
	exports: [StartCheckTestComponent],
	providers: [
		{
			provide: MatDialogRef,
			useValue: {}
		}
	]
})
export class StartCheckTestModule {}
