import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CheckGrammarComponent } from './check-grammar.component';

describe('CheckGrammarComponent', () => {
	let component: CheckGrammarComponent;
	let fixture: ComponentFixture<CheckGrammarComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [CheckGrammarComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(CheckGrammarComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
