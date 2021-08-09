import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TranslateModule } from '@ngx-translate/core';
import { MatButtonModule } from '@angular/material/button';
import { RouterModule } from '@angular/router';
import { MatMenuModule } from '@angular/material/menu';
import { MenuDroppableComponent } from './menu-droppable.component';
import { MatIconModule } from '@angular/material/icon';

@NgModule({
	declarations: [MenuDroppableComponent],
	imports: [CommonModule, TranslateModule, MatButtonModule, RouterModule, MatMenuModule, MatIconModule],
	exports: [MenuDroppableComponent]
})
export class MenuDroppableModule {}
