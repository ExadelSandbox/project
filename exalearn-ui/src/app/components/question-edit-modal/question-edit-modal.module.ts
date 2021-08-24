import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { QuestionEditModalComponent } from './question-edit-modal.component';
import { TranslateModule } from '@ngx-translate/core';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { FormsModule } from '@angular/forms';

@NgModule({
	declarations: [QuestionEditModalComponent],
	imports: [CommonModule, TranslateModule, MatInputModule, MatButtonModule, MatFormFieldModule, FormsModule]
})
export class QuestionEditModalModule {}
