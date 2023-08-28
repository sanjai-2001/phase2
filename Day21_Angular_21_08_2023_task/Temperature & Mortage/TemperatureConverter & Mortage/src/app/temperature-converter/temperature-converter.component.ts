import { Component } from '@angular/core';

@Component({
  selector: 'app-temperature-converter',
  templateUrl: './temperature-converter.component.html',
  styleUrls: ['./temperature-converter.component.css']
})
export class TemperatureConverterComponent {
  inputTemperature!: number;
  selectedUnit: string = 'Celsius';
  convertedTemperature: number | null = null;

  convertTemperature() {
    if (this.selectedUnit === 'Celsius') {
      this.convertedTemperature = (this.inputTemperature - 32) * 5 / 9;
    } else {
      this.convertedTemperature = (this.inputTemperature * 9 / 5) + 32;
    }
  }
}
