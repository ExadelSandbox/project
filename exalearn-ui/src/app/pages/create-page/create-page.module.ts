import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatTabsModule } from '@angular/material/tabs';

import { CreatePageComponent } from './create-page.component';

@NgModule({
	declarations: [CreatePageComponent],
	imports: [CommonModule, MatTabsModule],
	exports: [CreatePageComponent]
})
export class CreatePageModule {}
