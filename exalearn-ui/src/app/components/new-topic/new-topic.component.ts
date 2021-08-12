import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, FormGroupDirective, Validators } from '@angular/forms';

import { NewContentService } from '../../services/new-content.service';
import { ApiService } from '../../services/api.service';
import { API_PATH } from '../../constants/api.constants';
import { NotificationService } from '../../services/notification.service';

@Component({
	selector: 'app-new-topic',
	templateUrl: './new-topic.component.html',
	styleUrls: ['./new-topic.component.scss']
})
export class NewTopicComponent implements OnInit {
	@ViewChild(FormGroupDirective, { static: false })
	form: FormGroupDirective;

	topicForm: FormGroup;
	load = false;

	constructor(
		private fb: FormBuilder,
		private ncService: NewContentService,
		private apiServise: ApiService,
		private notificationService: NotificationService
	) {
		this.topicForm = this.fb.group({
			topics: this.fb.array([
				this.fb.control('', [
					Validators.required,
					Validators.minLength(2),
					this.ncService.noWhitespaceValidator
				])
			])
		});
	}

	ngOnInit(): void {}

	get topics(): any {
		return this.topicForm.get('topics');
	}

	addTopic(): void {
		this.topics.push(
			this.fb.control('', [Validators.required, Validators.minLength(2), this.ncService.noWhitespaceValidator])
		);
	}

	deleteTopic(index: number): void {
		this.topics.removeAt(index);
	}

	resetForm(): void {
		this.form.resetForm();

		while (this.topics.length !== 1) {
			this.deleteTopic(0);
		}
	}

	onSubmit(): void {
		this.load = true;
		void this.apiServise
			.postRequest(API_PATH.NEW_TOPIC, this.topicForm.value)
			.then(() => {
				this.notificationService.successPopUp();
				this.form.resetForm();
			})
			.catch(() => {
				this.notificationService.errorPopUp('Sorry. Something went wrong');
			})
			.finally(() => (this.load = false));
	}
}
