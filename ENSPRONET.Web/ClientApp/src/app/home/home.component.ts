import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { FormControl, FormGroup } from '@angular/forms';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public countrySearchForm: FormGroup;
  public country: Country = {
    countryName: '',
    alpha2Code: '',
    alpha3Code: '',
    numericCode: 0,
    subDivisionCode: '',
    internetDomain: '',
  }
  inputValue: string = '';

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private router: Router) {
    this.countrySearchForm = new FormGroup({
      alpha2code: new FormControl(""),
      });
  }

  onSubmit() {
    this.inputValue = this.countrySearchForm.get("alpha2code")?.value;
    console.log(this.inputValue);
    this.router.navigate(['/country-info-a2c/',this.inputValue]);
  }


}

interface Country {
  countryName: string;
  alpha2Code: string;
  alpha3Code: string;
  numericCode: number;
  subDivisionCode: string;
  internetDomain: string;
}