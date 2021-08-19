import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from '../../modules/app-routing/app-routing.module';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatTabsModule } from '@angular/material/tabs';
import { MatStepperModule } from '@angular/material/stepper';
import { MatIconModule } from '@angular/material/icon';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSliderModule } from '@angular/material/slider';
import { MatListModule } from '@angular/material/list';
import { MatDividerModule } from '@angular/material/divider';
import { MatDialogModule } from '@angular/material/dialog';
import { TranslateModule } from '@ngx-translate/core';
import { CoachPlayerComponent } from './coach-player.component';
import { ToasterModule } from 'angular2-toaster';

@NgModule({
	declarations: [CoachPlayerComponent],
	imports: [
		BrowserModule,
		AppRoutingModule,
		FormsModule,
		CommonModule,
		MatButtonModule,
		MatTabsModule,
		MatStepperModule,
		MatIconModule,
		MatToolbarModule,
		MatSliderModule,
		MatListModule,
		MatDividerModule,
		MatDialogModule,
		TranslateModule,
		ToasterModule
	],
	exports: [CoachPlayerComponent]
})
export class CoachPlayerModule {}
