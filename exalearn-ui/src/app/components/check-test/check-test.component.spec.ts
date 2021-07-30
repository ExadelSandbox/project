import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CheckTestComponent } from './check-test.component';

describe('CheckTestComponent', () => {
	let component: CheckTestComponent;
	let fixture: ComponentFixture<CheckTestComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [CheckTestComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(CheckTestComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
