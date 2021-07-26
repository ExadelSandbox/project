import { Component, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { environment } from '../../../environments/environment';
import { CookieService } from 'ngx-cookie-service';

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

	constructor(public translateService: TranslateService, public cookies: CookieService) {
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
		}
	}
}
