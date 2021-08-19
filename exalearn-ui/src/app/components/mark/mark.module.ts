import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';

import { MarkComponent } from './mark.component';

@NgModule({
	declarations: [MarkComponent],
	imports: [CommonModule, MatButtonModule],
	exports: [MarkComponent]
})
export class MarkModule {}
