import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MenuDroppableComponent } from './menu-droppable.component';

describe('MenuDroppableComponent', () => {
	let component: MenuDroppableComponent;
	let fixture: ComponentFixture<MenuDroppableComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [MenuDroppableComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(MenuDroppableComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
