import { Component, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { environment } from '../../../environments/environment';

@Component({
	selector: 'app-footer',
	templateUrl: './footer.component.html',
	styleUrls: ['./footer.component.scss']
})
export class FooterComponent implements OnInit {
	//TODO TESTING TRANSLATION MODULE
	translate: TranslateService;

	constructor(public translateService: TranslateService) {
		translateService.addLangs(['en_EN', 'ru_RU']);
		translateService.setDefaultLang('en_EN');
		const browserLang = translateService.getBrowserLang();
		translateService.use(/en_EN|ru_RU/.exec(browserLang) ? browserLang : 'en_EN');
	}

	ngOnInit(): void {
		this.translateService.use(environment.defaultLocale);
	}
}
