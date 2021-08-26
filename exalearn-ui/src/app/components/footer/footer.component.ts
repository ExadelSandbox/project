import { Component, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { environment } from '../../../environments/environment';
import { CookieService } from 'ngx-cookie-service';
import { BodyOutputType, Toast, ToasterConfig, ToasterService } from 'angular2-toaster';
import { configPopUp } from '../../services/utils.service';

@Component({
	selector: 'app-footer',
	templateUrl: './footer.component.html',
	styleUrls: ['./footer.component.scss']
})
export class FooterComponent implements OnInit {
	translate: TranslateService;
	lastSelectedLanguage: any;
	allCookieData: any;
	checkCookie: any;
	dateFormat = require('dateFormat');
	now = new Date();
	dateOnFooter = this.dateFormat(this.now, 'fullDate');

	constructor(
		public translateService: TranslateService,
		public cookies: CookieService,
		toasterService: ToasterService
	) {
		this.toasterService = toasterService;
		this.configPopUp = configPopUp;
		translateService.addLangs(environment.locales);
		translateService.setDefaultLang(environment.defaultLocale);
	}

	ngOnInit(): void {
		this.allCookieData = this.cookies.getAll();
		this.checkCookie = this.cookies.check('lastSelectedLanguage');

		if (this.checkCookie) {
			this.translateService.use(this.cookies.get('lastSelectedLanguage'));
		} else {
			this.cookies.set('lastSelectedLanguage', environment.defaultLocale, 2);
			this.translateService.use(environment.defaultLocale);
			this.popMeUp();
		}
	}

	private toasterService: ToasterService;
	public configPopUp: ToasterConfig;

	public popMeUp(): void {
		const toast: Toast = {
			type: 'info',
			title: 'Cookie info',
			timeout: 5000,
			body: 'Our site uses cookies, by staying on the site, you confirm that you agree with our terms of use of the site',
			bodyOutputType: BodyOutputType.TrustedHtml,
			progressBar: true,
			progressBarDirection: 'increasing'
		};
		this.toasterService.popAsync(toast);
	}
}
