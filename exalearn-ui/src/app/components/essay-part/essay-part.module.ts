import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatInputModule } from '@angular/material/input';

import { EssayPartComponent } from './essay-part.component';
import { TranslateModule } from '@ngx-translate/core';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatIconModule } from '@angular/material/icon';
import { MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatTooltipModule } from '@angular/material/tooltip';

@NgModule({
	declarations: [EssayPartComponent],
	imports: [
		BrowserModule,
		MatInputModule,
		TranslateModule,
		MatProgressSpinnerModule,
		MatIconModule,
		MatDialogModule,
		MatButtonModule,
		MatTooltipModule
	],
	exports: [EssayPartComponent]
})
export class EssayPartModule {}
