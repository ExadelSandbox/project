import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from '../header/header.component';
import { TranslateModule } from '@ngx-translate/core';
import { MatButtonModule } from '@angular/material/button';
import { AuthService } from '../../services/auth.service';

@NgModule({
	declarations: [HeaderComponent],
	imports: [CommonModule, TranslateModule, MatButtonModule],
	providers: [AuthService],
	exports: [HeaderComponent]
})
export class HeaderModule {}
