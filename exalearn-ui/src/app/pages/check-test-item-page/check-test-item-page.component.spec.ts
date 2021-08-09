import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CheckTestItemPageComponent } from './check-test-item-page.component';

describe('CheckTestItemPageComponent', () => {
	let component: CheckTestItemPageComponent;
	let fixture: ComponentFixture<CheckTestItemPageComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [CheckTestItemPageComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(CheckTestItemPageComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
