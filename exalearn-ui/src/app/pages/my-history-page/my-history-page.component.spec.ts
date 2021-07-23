import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyHistoryPageComponent } from './my-history-page.component';

describe('MyHistoryPageComponent', () => {
	let component: MyHistoryPageComponent;
	let fixture: ComponentFixture<MyHistoryPageComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [MyHistoryPageComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(MyHistoryPageComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
