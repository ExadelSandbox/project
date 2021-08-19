import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';

import { MarkComponent } from './mark.component';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [MarkComponent],
	imports: [CommonModule, MatButtonModule, TranslateModule],
	exports: [MarkComponent]
})
export class MarkModule {}
