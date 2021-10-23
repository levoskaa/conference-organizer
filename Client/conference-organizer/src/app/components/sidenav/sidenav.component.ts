import { ChangeDetectorRef, Component, ElementRef, OnInit } from '@angular/core';
import { MatDrawerContent, MatSidenav } from '@angular/material/sidenav';

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.scss']
})
export class SidenavComponent implements OnInit {

  constructor() {
  }

  ngOnInit(): void {
  }

}
