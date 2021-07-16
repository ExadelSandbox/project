import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TestNavBtnComponent } from './test-nav-btn.component';

describe('TestNavBtnComponent', () => {
	let component: TestNavBtnComponent;
	let fixture: ComponentFixture<TestNavBtnComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [TestNavBtnComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(TestNavBtnComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
