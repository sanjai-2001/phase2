import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { TemperatureConverterComponent } from 'src/app/temperature-converter/temperature-converter.component';
import { MortgageCalculatorComponent } from './mortgage-calculator/mortgage-calculator.component';

@NgModule({
  declarations: [
    AppComponent,
    TemperatureConverterComponent,
    MortgageCalculatorComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
