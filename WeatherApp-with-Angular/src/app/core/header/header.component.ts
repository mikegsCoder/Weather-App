import { Component, OnInit } from '@angular/core';
import { angularUrl } from '../../shared/constants/appConstants'
import { logo } from '../../shared/constants/appConstants';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
})
export class HeaderComponent implements OnInit {
  logo: string;
  angularUrl: string;

  constructor() {
    this.logo = logo;
    this.angularUrl = angularUrl;
  }

  ngOnInit(): void {
    document.body.classList.add('light');
  }

  toggleTheme = (): void => {
    if (document.body.classList.contains('dark')) {
      document.body.classList.remove('dark');
      document.body.classList.add('light');
    } else if (document.body.classList.contains('light')) {
      document.body.classList.remove('light');
      document.body.classList.add('dark');
    }
  };
}
