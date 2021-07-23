import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TestsAssignedByUserComponent } from './tests-assigned-by-user.component';

describe('TestsAssignedByUserComponent', () => {
	let component: TestsAssignedByUserComponent;
	let fixture: ComponentFixture<TestsAssignedByUserComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [TestsAssignedByUserComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(TestsAssignedByUserComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
