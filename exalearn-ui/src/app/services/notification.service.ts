import { Injectable } from '@angular/core';
import { BodyOutputType, Toast, ToasterConfig, ToasterService } from 'angular2-toaster';

@Injectable({
	providedIn: 'root'
})
export class NotificationService {
	private toasterService: ToasterService;

	constructor(toasterService: ToasterService) {
		this.toasterService = toasterService;
	}

	public errorPopUp(errorText: string): void {
		const toast: Toast = {
			type: 'error',
			title: 'Error',
			timeout: 3000,
			body: errorText,
			bodyOutputType: BodyOutputType.TrustedHtml,
			progressBar: false
		};
		this.toasterService.popAsync(toast);
	}

	public successPopUp(): void {
		const toast: Toast = {
			type: 'success',
			title: 'Done',
			timeout: 3000,
			body: 'Very nice, great success!',
			bodyOutputType: BodyOutputType.TrustedHtml,
			progressBar: true,
			progressBarDirection: 'increasing'
		};
		this.toasterService.popAsync(toast);
	}

	public messagePopUp(infoText: string): void {
		const toast: Toast = {
			type: 'error',
			title: 'Error',
			timeout: 5000,
			body: infoText,
			bodyOutputType: BodyOutputType.TrustedHtml,
			progressBar: true,
			progressBarDirection: 'increasing'
		};
		this.toasterService.popAsync(toast);
	}
}

export const configPopUp: ToasterConfig = new ToasterConfig({
	limit: 1,
	tapToDismiss: true,
	showCloseButton: false,
	mouseoverTimerStop: true,
	animation: 'fade',
	positionClass: 'toast-bottom-center'
});

export const configPopUpCenter: ToasterConfig = new ToasterConfig({
	limit: 1,
	tapToDismiss: true,
	showCloseButton: false,
	mouseoverTimerStop: true,
	animation: 'fade',
	positionClass: 'toast-center'
});

export const configPopUpBottomRight: ToasterConfig = new ToasterConfig({
	limit: 1,
	tapToDismiss: true,
	showCloseButton: false,
	mouseoverTimerStop: true,
	animation: 'fade',
	positionClass: 'toast-bottom-right'
});

export const configPopUpTopFull: ToasterConfig = new ToasterConfig({
	limit: 1,
	tapToDismiss: true,
	showCloseButton: false,
	mouseoverTimerStop: true,
	animation: 'fade',
	positionClass: 'toast-top-full-width'
});
