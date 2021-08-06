import { Component, OnInit } from '@angular/core';
import { RolesService } from '../../services/roles.service';
import { RedirectBtn } from '../../interfaces/interfaces';

@Component({
	selector: 'app-main-page',
	templateUrl: './main-page.component.html',
	styleUrls: ['./main-page.component.scss']
})
export class MainPageComponent implements OnInit {
	btns: readonly RedirectBtn[] = [];
  
	constructor(private roleService: RolesService) {}

	ngOnInit(): void {
		this.btns = this.roleService.getBtns('coach');
	}
}
