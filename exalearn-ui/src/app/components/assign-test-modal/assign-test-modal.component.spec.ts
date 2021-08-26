import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AssignTestModalComponent } from './assign-test-modal.component';

describe('AssignTestModalComponent', () => {
	let component: AssignTestModalComponent;
	let fixture: ComponentFixture<AssignTestModalComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [AssignTestModalComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(AssignTestModalComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
