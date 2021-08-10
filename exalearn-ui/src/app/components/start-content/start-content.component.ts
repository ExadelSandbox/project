import { Component } from '@angular/core';
import { UserService } from '../../services/user.service';
import { EnglishLevels } from '../../enums/enums';

@Component({
	selector: 'app-start-content',
	templateUrl: './start-content.component.html',
	styleUrls: ['./start-content.component.scss']
})
export class StartContentComponent {
	userName: string;
	userLevel: EnglishLevels | null;
	constructor(public userService: UserService) {}
	ngOnInit() {
		if (this.userService.currentUser) {
			this.userName = this.userService.currentUser.fullName;
			this.userLevel = this.userService.currentUser.level;
		}
	}
}
