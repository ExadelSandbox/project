import { Component } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent {
  isAppInitialized = true;
  isAuthorized = true;

  public profile() {

  }

  public logout() {
  
  }
}
