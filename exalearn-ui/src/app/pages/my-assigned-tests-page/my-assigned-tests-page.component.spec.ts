import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyAssignedTestsPageComponent } from './my-assigned-tests-page.component';

describe('MyAssignedTestsPageComponent', () => {
	let component: MyAssignedTestsPageComponent;
	let fixture: ComponentFixture<MyAssignedTestsPageComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [MyAssignedTestsPageComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(MyAssignedTestsPageComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
