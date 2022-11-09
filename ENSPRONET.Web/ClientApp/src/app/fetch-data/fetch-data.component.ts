import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { FormControl, FormGroup } from "@angular/forms";

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecastInsertForm: FormGroup;
  public forecasts: WeatherForecast[] = [];
  public countryID: string | null = "";
  public countryName: string | null = "";
  public showForm: boolean = false;
  public successPost: boolean = false;

  
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private activatedRoute: ActivatedRoute) {
    this.forecastInsertForm = new FormGroup({
      date: new FormControl(''),
      temperatureC: new FormControl(''),
      summary: new FormControl(''),
      countryID: new FormControl(''),
    });
  }

  ngOnInit() {
    this.countryName = this.activatedRoute.snapshot.paramMap.get("countryName");
    this.countryID = this.activatedRoute.snapshot.paramMap.get("countryID");
    this.forecastInsertForm.patchValue({countryID : this.countryID});
    this.http.get<WeatherForecast[]>(this.baseUrl + 'weatherforecast/GetbyCountry/' + this.countryID).subscribe(result => {
      this.forecasts = result;
    }, 
   
    error => console.error(error));
}

onSubmit() {
  console.log(this.forecastInsertForm.value);
  this.http.post<number>(this.baseUrl + 'weatherforecast', this.forecastInsertForm.value).subscribe(result => {
    console.log(result);
  this.showForm = false;
  this.successPost = true;
  this.ngOnInit();
  });
  
}

}



interface WeatherForecast {
  id:number;
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
  countryID: number;
  
}
