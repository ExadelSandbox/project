import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, FormGroupDirective, Validators } from '@angular/forms';

import { NewContentService } from '../../services/new-content.service';
import { ApiService } from '../../services/api.service';
import { API_PATH } from '../../constants/api.constants';
import { NotificationService } from '../../services/notification.service';
import { TranslateService } from '@ngx-translate/core';

@Component({
	selector: 'app-new-topic',
	templateUrl: './new-topic.component.html',
	styleUrls: ['./new-topic.component.scss']
})
export class NewTopicComponent implements OnInit {
	@ViewChild(FormGroupDirective, { static: false })
	form: FormGroupDirective;
	private translateService: TranslateService;
	topicForm: FormGroup;
	load = false;
	isValid = true;

	constructor(
		private fb: FormBuilder,
		private ncService: NewContentService,
		private apiServise: ApiService,
		private notificationService: NotificationService,
		translateService: TranslateService
	) {
		this.translateService = translateService;
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

	trimForm(): void {
		this.topics['controls'].forEach((element: FormGroup) => {
			const trimmedString: string = element.controls.topic.value.trim();
			element.controls.topic.setValue(trimmedString[0].toUpperCase() + trimmedString.substr(1));
		});
	}

	validFields(): boolean {
		this.trimForm();
		return this.topicForm.valid;
	}

	onSubmit(): void {
		this.isValid = this.validFields();
		if (this.isValid) {
			this.load = true;
			void this.apiServise
				.postRequest(API_PATH.NEW_TOPIC, this.topicForm.value.topics)
				.then(() => {
					this.notificationService.successPopUp();
					this.resetForm();
				})
				.catch(() => {
					this.notificationService.errorPopUp(this.translateService.instant('NOTIFICATION.ERROR_TRY_AGAIN'));
				})
				.finally(() => (this.load = false));
		}
	}
}
