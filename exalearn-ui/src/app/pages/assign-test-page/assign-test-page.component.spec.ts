import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AssignTestPageComponent } from './assign-test-page.component';

describe('AssignTestPageComponent', () => {
	let component: AssignTestPageComponent;
	let fixture: ComponentFixture<AssignTestPageComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [AssignTestPageComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(AssignTestPageComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
