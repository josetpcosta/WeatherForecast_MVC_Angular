import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-delete-temperature',
  templateUrl: './delete-temperature.component.html',
})
export class DeleteTemperatureComponent {

  public forecasts: WeatherForecast[] = [];

  public countryName: string | null = "";
  private temperatureID: string | null = "";
  public countryID: string | null = "";
  public successRequest: boolean = false;
  public errorRequest: boolean = false;

  public weatherForecast: WeatherForecast = {
    id: 0,
    date: '',
    temperatureC: 0,
    temperatureF: 0,
    summary: '',
    country: {
      id: 0,
      countryName: '',
      alpha2Code: '',
      alpha3Code: '',
      numericCode: 0,
      subDivisionCode: '',
      internetDomain: '',
    }
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private activatedRoute: ActivatedRoute) {

  }

  ngOnInit() {
    this.temperatureID = this.activatedRoute.snapshot.paramMap.get("temperatureID");
    this.countryID = this.activatedRoute.snapshot.paramMap.get("countryID");
    this.countryName = this.activatedRoute.snapshot.paramMap.get("countryName");
    this.http.get<WeatherForecast>(this.baseUrl + 'weatherforecast/GetTemperatureByID/' + this.temperatureID).subscribe(result => {
      this.weatherForecast = result;
      console.log(this.weatherForecast);
    },

      error => console.error(error));
  }

  onClickDelete(temperatureID: number) {

    this.http.delete(this.baseUrl + 'weatherforecast?id=' + temperatureID).subscribe(result => {
      this.successRequest = true;

      
    }, error => {
      this.errorRequest = true;
      this.successRequest = false;
    });
  }

}

interface Country {
  id: number;
  countryName: string;
  alpha2Code: string;
  alpha3Code: string;
  numericCode: number;
  subDivisionCode?: string;
  internetDomain?: string;
}


interface WeatherForecast {
  id: number;
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
  country: Country;
  
}