import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CheckNavBtnComponent } from './check-nav-btn.component';

describe('CheckNavBtnComponent', () => {
	let component: CheckNavBtnComponent;
	let fixture: ComponentFixture<CheckNavBtnComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [CheckNavBtnComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(CheckNavBtnComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
