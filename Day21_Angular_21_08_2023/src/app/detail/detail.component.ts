import { Component } from '@angular/core';
import { TemporaryService } from '../temporary.service';

@Component({
  selector: 'app-detail',
  templateUrl: './detail.component.html',
  styleUrls: ['./detail.component.css']
})
export class DetailComponent {

  constructor(public temp:TemporaryService){}

}
