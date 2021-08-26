import { NgModule } from '@angular/core';
import { StartTestModalComponent } from './start-test-modal.component';
import { MatDialogModule } from '@angular/material/dialog';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectModule } from '@angular/material/select';
import { BrowserModule } from '@angular/platform-browser';
import { TranslateModule } from '@ngx-translate/core';
import { MatIconModule } from '@angular/material/icon';

@NgModule({
	declarations: [StartTestModalComponent],
	imports: [
		MatDialogModule,
		FormsModule,
		MatFormFieldModule,
		MatButtonModule,
		MatSelectModule,
		BrowserModule,
		TranslateModule,
		MatIconModule
	],
	exports: [StartTestModalComponent]
})
export class StartTestModalModule {}
