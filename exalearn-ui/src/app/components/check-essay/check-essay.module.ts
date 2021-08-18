import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { MatInputModule } from '@angular/material/input';
import { TranslateModule } from '@ngx-translate/core';

import { CheckEssayComponent } from './check-essay.component';
import { MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';

@NgModule({
	declarations: [CheckEssayComponent],
	imports: [
		CommonModule,
		MatInputModule,
		TranslateModule,
		MatInputModule,
		BrowserModule,
		MatDialogModule,
		MatButtonModule
	],
	exports: [CheckEssayComponent]
})
export class CheckEssayModule {}
