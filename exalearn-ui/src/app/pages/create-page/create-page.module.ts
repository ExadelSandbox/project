import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatTabsModule } from '@angular/material/tabs';

import { CreatePageComponent } from './create-page.component';
import { NewListeningModule } from '../../components/new-listening/new-listening.module';

@NgModule({
	declarations: [CreatePageComponent],
	imports: [CommonModule, MatTabsModule, NewListeningModule],
	exports: [CreatePageComponent]
})
export class CreatePageModule {}
