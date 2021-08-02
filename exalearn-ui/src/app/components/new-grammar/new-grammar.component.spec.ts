import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewGrammarComponent } from './new-grammar.component';

describe('NewGrammarComponent', () => {
	let component: NewGrammarComponent;
	let fixture: ComponentFixture<NewGrammarComponent>;

	beforeEach(async () => {
		await TestBed.configureTestingModule({
			declarations: [NewGrammarComponent]
		}).compileComponents();
	});

	beforeEach(() => {
		fixture = TestBed.createComponent(NewGrammarComponent);
		component = fixture.componentInstance;
		fixture.detectChanges();
	});

	it('should create', () => {
		expect(component).toBeTruthy();
	});
});
