import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatRadioModule } from '@angular/material/radio';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatIconModule } from '@angular/material/icon';
import { TranslateModule } from '@ngx-translate/core';

import { NewGrammarComponent } from './new-grammar.component';

@NgModule({
	declarations: [NewGrammarComponent],
	imports: [
		CommonModule,
		FormsModule,
		ReactiveFormsModule,
		MatInputModule,
		MatButtonModule,
		MatRadioModule,
		MatSelectModule,
		MatFormFieldModule,
		MatProgressBarModule,
		MatIconModule,
		TranslateModule
	],
	exports: [NewGrammarComponent]
})
export class NewGrammarModule {}
