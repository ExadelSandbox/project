import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FinishTestButtonComponent } from './finish-test-button.component';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';

@NgModule({
	declarations: [FinishTestButtonComponent],
	imports: [CommonModule, MatIconModule, MatButtonModule],
	exports: [FinishTestButtonComponent]
})
export class FinishTestButtonModule {}
