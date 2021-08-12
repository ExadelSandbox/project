import { Component, OnInit } from '@angular/core';
import { ToasterConfig, ToasterModule } from 'angular2-toaster';
import { configPopUp, NotificationService } from '../../services/notification.service';

@Component({
	selector: 'app-create-page',
	templateUrl: './create-page.component.html',
	styleUrls: ['./create-page.component.scss']
})
export class CreatePageComponent implements OnInit {
	public configPopUp: ToasterConfig;
	constructor(private notificationService: NotificationService) {
		this.configPopUp = configPopUp;
	}
	ngOnInit(): void {}
}
