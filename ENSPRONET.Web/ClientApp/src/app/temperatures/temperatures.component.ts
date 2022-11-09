import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-temperatures',
  templateUrl: './temperatures.component.html',
})
export class TemperaturesComponent {
  public countryName: string | null = "";
  public forecasts: WeatherForecast[] = [];
  private temperatureID: string | null = "";
  public countryID: string | null = "";
  public weatherForecast: WeatherForecast = {
    id: 0,
    date: '',
    temperatureC: 0,
    temperatureF: 0,
    summary: ''
    
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private activatedRoute: ActivatedRoute) {
    
  }

  ngOnInit() {
    this.countryName = this.activatedRoute.snapshot.paramMap.get("countryName");
    this.temperatureID = this.activatedRoute.snapshot.paramMap.get("temperatureID");
    this.countryID = this.activatedRoute.snapshot.paramMap.get("countryID");
    this.http.get<WeatherForecast>(this.baseUrl + 'weatherforecast/GetTemperatureByID/' + this.temperatureID).subscribe(result => {
      this.weatherForecast = result;
      console.log(this.weatherForecast);
    }, 
   
    error => console.error(error));

}

}


interface WeatherForecast {
  id: number;
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
  
}