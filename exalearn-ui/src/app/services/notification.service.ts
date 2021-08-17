import { Injectable } from '@angular/core';
import { BodyOutputType, Toast, ToasterConfig, ToasterService } from 'angular2-toaster';
import { TranslateService } from '@ngx-translate/core';

@Injectable({
	providedIn: 'root'
})
export class NotificationService {
	private toasterService: ToasterService;
	private translateService: TranslateService;

	constructor(toasterService: ToasterService, translateService: TranslateService) {
		this.toasterService = toasterService;
		this.translateService = translateService;
	}

	public errorPopUp(errorText: string): void {
		const toast: Toast = {
			type: 'error',
			title: this.translateService.instant('NOTIFICATION.ERROR_TITLE'),
			timeout: 2000,
			body: errorText,
			bodyOutputType: BodyOutputType.TrustedHtml,
			progressBar: false
		};
		this.toasterService.popAsync(toast);
	}

	public successPopUp(): void {
		const toast: Toast = {
			type: 'success',
			title: this.translateService.instant('NOTIFICATION.SUCCESS_TITLE'),
			timeout: 2000,
			body: this.translateService.instant('NOTIFICATION.SUCCESS_MESSAGE'),
			bodyOutputType: BodyOutputType.TrustedHtml,
			progressBar: false
		};
		this.toasterService.popAsync(toast);
	}

	public messagePopUp(infoText: string): void {
		const toast: Toast = {
			type: 'info',
			title: this.translateService.instant('NOTIFICATION.INFO_TITLE'),
			timeout: 2000,
			body: infoText,
			bodyOutputType: BodyOutputType.TrustedHtml,
			progressBar: false
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
