import { Component, OnInit } from '@angular/core';
import { RolesService } from '../../services/roles.service';
import { RedirectBtn } from '../../interfaces/interfaces';

@Component({
	selector: 'app-menu',
	templateUrl: './menu.component.html',
	styleUrls: ['./menu.component.scss']
})
export class MenuComponent implements OnInit {
	btns: readonly RedirectBtn[] = [];

	constructor(private roleService: RolesService) {}

	ngOnInit(): void {
		this.btns = this.roleService.getBtns('hr');
	}
}
