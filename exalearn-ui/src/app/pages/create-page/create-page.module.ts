import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatTabsModule } from '@angular/material/tabs';

import { CreatePageComponent } from './create-page.component';
import { NewListeningModule } from '../../components/new-listening/new-listening.module';
import { NewGrammarModule } from '../../components/new-grammar/new-grammar.module';
import { NewTopicModule } from 'src/app/components/new-topic/new-topic.module';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
	declarations: [CreatePageComponent],
	imports: [CommonModule, MatTabsModule, NewListeningModule, TranslateModule, NewGrammarModule, NewTopicModule],
	exports: [CreatePageComponent]
})
export class CreatePageModule {}
