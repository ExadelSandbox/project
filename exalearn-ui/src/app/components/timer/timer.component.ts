import { Component, OnInit, Input, OnChanges, SimpleChanges, ViewChild, ElementRef } from '@angular/core';
import { TimerService } from '../../services/timer.service';
import { AfterViewInit } from '@angular/core';

@Component({
	selector: 'app-timer',
	templateUrl: './timer.component.html',
	styleUrls: ['./timer.component.scss'],
	providers: [TimerService]
})
export class TimerComponent implements OnInit, OnChanges, AfterViewInit {
	@Input() startTimerOnInit = false;
	@Input() speakingTimerStarted = false;
	@Input() label = '';
	@Input() mode = '';
	@Input() resetSpeakingTimer = false;

	@ViewChild('timer', { read: ElementRef })
	timerContainer: ElementRef;

	public time: { mins: string; secs: string } = { mins: '00', secs: '00' };
	public speakingTimerInterval: any;

	constructor(private timerService: TimerService) {}

	ngOnInit(): void {
		if (this.startTimerOnInit) {
			this.startTotalDurationTimer();
		}
	}

	ngAfterViewInit(): void {
		this.timerContainer.nativeElement.classList.add(this.mode);
	}

	ngOnChanges(changes: SimpleChanges) {
		if (this.speakingTimerStarted) {
			this.startSpeakingTimer();
		} else {
			this.timerService.pauseTimer(this.speakingTimerInterval);
		}

		if (this.resetSpeakingTimer) {
			this.timerService.resetTimer(this.speakingTimerInterval);
		}
	}

	startTotalDurationTimer() {
		const timerInterval = setInterval(() => {
			this.time = this.timerService.displayTimeLeft(timerInterval, this.time.mins, this.time.secs);
		}, 1000);
	}

	startSpeakingTimer() {
		this.speakingTimerInterval = setInterval(() => {
			this.time = this.timerService.displayTimePassed(this.speakingTimerInterval, this.time.mins, this.time.secs);
		}, 1000);
	}
}
