import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CheckTestPageComponent } from './check-test-page.component';

describe('CheckTestPageComponent', () => {
	let component: CheckTestPageComponent;
	let fixture: ComponentFixture<CheckTestPageComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [CheckTestPageComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(CheckTestPageComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
