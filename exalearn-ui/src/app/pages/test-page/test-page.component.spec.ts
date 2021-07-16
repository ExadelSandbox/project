import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TestPageComponent } from './test-page.component';

describe('TestMainComponent', () => {
	let component: TestPageComponent;
	let fixture: ComponentFixture<TestPageComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [TestPageComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(TestPageComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
