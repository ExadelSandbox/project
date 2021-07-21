import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { SpeakingComponent } from './speaking.component';

@NgModule({
	imports: [CommonModule, MatButtonModule],
	declarations: [SpeakingComponent],
	exports: [SpeakingComponent]
})
export class SpeakingModule {}
