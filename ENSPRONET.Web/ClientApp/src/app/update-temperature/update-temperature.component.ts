import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-update-temperature',
  templateUrl: './update-temperature.component.html',
})
export class UpdateTemperatureComponent {

  public temperatureUpdateForm: FormGroup;

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
    summary: ''
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private activatedRoute: ActivatedRoute, private router: Router) {
    this.temperatureUpdateForm = new FormGroup({
        id: new FormControl(""),
        date: new FormControl(""),
        temperatureC: new FormControl(""),
        temperatureF: new FormControl(""),
        summary: new FormControl(""),
    });
}

  ngOnInit() {
    this.temperatureID = this.activatedRoute.snapshot.paramMap.get("temperatureID");
    this.countryID = this.activatedRoute.snapshot.paramMap.get("countryID");
    this.countryName = this.activatedRoute.snapshot.paramMap.get("countryName");
    this.http.get<WeatherForecast>(this.baseUrl + 'weatherforecast/GetTemperatureByID/' + this.temperatureID).subscribe(result => {
      this.weatherForecast = result;
      this.temperatureUpdateForm.patchValue({
        id: this.weatherForecast.id,
        date: this.weatherForecast.date,
        temperatureC: this.weatherForecast.temperatureC,
        temperatureF: this.weatherForecast.temperatureF,
        summary: this.weatherForecast.summary
      });
    });

  }

  onSubmit() {
    this.http.put(this.baseUrl + 'weatherforecast?id=' + this.weatherForecast.id, this.temperatureUpdateForm.value).subscribe(result => {
        this.successRequest = true;
    }, error => { this.errorRequest = true; });
}

}



interface WeatherForecast {
  id: number;
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
  
}