import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.scss']
})
export class FooterComponent implements OnInit {
  title='Group 2. Last changes: 01.01.21'
  constructor() {
  }
  ngOnInit():void {
  }
}
