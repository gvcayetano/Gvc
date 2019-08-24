import { Component, OnInit } from '@angular/core';
import { AboutLinks } from './AboutLinks';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html'
})
export class AboutComponent implements OnInit {
  links: Array<AboutLinks>;
  constructor() {
    this.links = new Array<AboutLinks>();
  }

  ngOnInit() {

    this.links.push({
      url:'http://bit.ly/2zhCJ4T',
      fontAwesome:'fab fa-facebook',
      username: '@gvcayetano'
    });

    this.links.push({
      url:'http://bit.ly/2MB63Ml',
      fontAwesome:'fab fa-github',
      username: '@gvcayetano'
    });

    this.links.push({
      url:'http://bit.ly/2PdP9Fz',
      fontAwesome:'fab fa-instagram',
      username: '@gvcayetano'
    });

    this.links.push({
      url:'http://bit.ly/2ZpLBQq',
      fontAwesome:'fab fa-linkedin',
      username: '@gvcayetano'
    });

    this.links.push({
      url:'http://bit.ly/2HikHUr',
      fontAwesome:'fab fa-twitter',
      username: '@gvcayetano'
    });
  }

}
