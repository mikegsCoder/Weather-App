import { Component } from '@angular/core';
import { dataProviderUrl, sourceCodeUrl } from '../../shared/constants/appConstants'

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css'],
})
export class FooterComponent {
  dataProviderUrl: string;
  sourceCodeUrl: string;

  constructor() {
    this.dataProviderUrl = dataProviderUrl;
    this.sourceCodeUrl = sourceCodeUrl;
  }
}
