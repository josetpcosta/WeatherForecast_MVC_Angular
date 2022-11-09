import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { FormControl, FormGroup } from "@angular/forms";

@Component({
  selector: 'app-countries',
  templateUrl: './countries.component.html',
})
export class CountriesComponent {
  public countryInsertForm: FormGroup;
  showTable: boolean = false;
  showForm: boolean = false;
  successPost: boolean = false;
  showInsertButton: boolean = true;
  showError: boolean = false;
  public countryName: string | null = "";

  public countries: Country[] = [];
  public forecasts: WeatherForecast[] = [];
  public country: Country = {
    id: -1,
    countryName: '',
    alpha2Code: '',
    alpha3Code: '',
    numericCode: 0,
    subDivisionCode: '',
    internetDomain: '',
  }
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private router: Router) {
    this.countryInsertForm = new FormGroup({
      countryName: new FormControl(''),
      alpha2Code: new FormControl(''),
      alpha3Code: new FormControl(''),
      numericCode: new FormControl(''),
      SubDivisionCode: new FormControl(''),
      InternetDomain: new FormControl(''),
    });
    http.get<Country[]>(baseUrl + 'country/GetAllCountries').subscribe(result => {
      this.countries = result;
    }, error => console.error(error));
  }

  onClickWF(countryID: number, countryName: string) {
    console.log(countryID);
    console.log(countryName);
    this.router.navigate(['/fetch-data/'+ countryName + "/"+ countryID]);
  }

  onSubmit() {
    console.log(this.countryInsertForm.value);
    this.http.post<number>(this.baseUrl + 'country', this.countryInsertForm.value).subscribe(result => {
      console.log(result);
      this.showForm = false;
      this.successPost = true;
      this.showInsertButton = true;
      this.ngOnInit();
    }, error => this.showError = true);
  }

  ngOnInit() {
    this.http.get<Country[]>(this.baseUrl + 'country/GetAllCountries').subscribe(result => {
      this.countries = result;
      this.showTable = true;
    }, error => console.error(error));
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
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}