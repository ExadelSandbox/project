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
		translateService.addLangs(environment.locales);
		translateService.setDefaultLang(environment.defaultLocale);
	}

	ngOnInit(): void {
		this.translateService.use(environment.defaultLocale);
	}
}
