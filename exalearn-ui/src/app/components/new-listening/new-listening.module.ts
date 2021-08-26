import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatRadioModule } from '@angular/material/radio';
import { MatInputModule } from '@angular/material/input';
import { MatTabsModule } from '@angular/material/tabs';
import { TranslateModule } from '@ngx-translate/core';

import { NewListeningComponent } from './new-listening.component';

@NgModule({
	declarations: [NewListeningComponent],
	imports: [
		CommonModule,
		MatProgressBarModule,
		MatButtonModule,
		MatIconModule,
		MatSelectModule,
		MatFormFieldModule,
		FormsModule,
		ReactiveFormsModule,
		MatRadioModule,
		MatInputModule,
		MatTabsModule,
		TranslateModule
	],
	exports: [NewListeningComponent]
})
export class NewListeningModule {}
