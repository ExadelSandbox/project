import { TestBed } from '@angular/core/testing';

import { AudioCloudService } from './audio-cloud.service';

describe('CloudService', () => {
	let service: AudioCloudService;

	beforeEach(() => {
		TestBed.configureTestingModule({});
		service = TestBed.inject(AudioCloudService);
	});

	it('should be created', () => {
		expect(service).toBeTruthy();
	});
});
