import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormGroupDirective, Validators } from '@angular/forms';

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
	isValid = true;

	constructor(
		private fb: FormBuilder,
		private ncService: NewContentService,
		private apiServise: ApiService,
		private notificationService: NotificationService
	) {
		this.topicForm = this.fb.group({
			topics: this.fb.array([
				this.fb.group({
					topic: ['', [Validators.required, Validators.minLength(2), this.ncService.noWhitespaceValidator]]
				})
			])
		});
	}

	ngOnInit(): void {}

	get topics(): any {
		return this.topicForm.get('topics');
	}

	addTopic(): void {
		this.topics.push(
			this.fb.group({
				topic: ['', [Validators.required, Validators.minLength(2), this.ncService.noWhitespaceValidator]]
			})
		);
	}

	deleteTopic(index: number): void {
		this.topics.removeAt(index);
	}

	resetForm(): void {
		this.form.resetForm();

		while (this.topics.value.length !== 1) {
			this.deleteTopic(0);
		}
	}

	cleanForm(): void {
		this.topics['controls'].forEach((element: FormGroup) => {
			element.controls.topic.setValue(element.controls.topic.value.trim());
		});
	}

	validForm(): boolean {
		this.cleanForm();
		return this.topicForm.valid;
	}

	onSubmit(): void {
		this.load = true;
		this.isValid = this.validForm();
		if (this.isValid) {
			void this.apiServise
				.postRequest(API_PATH.NEW_TOPIC, this.topicForm.value.topics)
				.then(() => {
					this.notificationService.successPopUp();
					this.resetForm();
				})
				.catch(() => {
					this.notificationService.errorPopUp('Sorry. Something went wrong');
				})
				.finally(() => (this.load = false));
		} else {
			this.load = false;
		}
	}
}
