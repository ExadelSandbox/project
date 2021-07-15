import { NgModule } from '@angular/core';
import { MatTabsModule } from '@angular/material/tabs';

const MaterialComponents = [MatTabsModule];

@NgModule({
	imports: [MaterialComponents],
	exports: [MaterialComponents]
})
export class TestPageModule {}
