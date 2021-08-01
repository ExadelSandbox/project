import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
import { MatProgressBarModule } from '@angular/material/progress-bar';

import { NewTopicComponent } from './new-topic.component';

@NgModule({
	declarations: [NewTopicComponent],
	imports: [
		CommonModule,
		ReactiveFormsModule,
		FormsModule,
		MatButtonModule,
		MatInputModule,
		MatIconModule,
		MatProgressBarModule
	],
	exports: [NewTopicComponent]
})
export class NewTopicModule {}
