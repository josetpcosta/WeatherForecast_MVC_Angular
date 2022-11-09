import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-country-info-a2c',
  templateUrl: './country-info-a2c.component.html',
})

export class CountryInfoA2cComponent {
  
  public showButton: boolean = false;
  private alpha2Code: string | null = "";
  public country: Country = {
    id: 0,
    countryName: '',
    alpha2Code: '',
    alpha3Code: '',
    numericCode: 0,
    subDivisionCode: '',
    internetDomain: '',
  }
  
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private activatedRoute: ActivatedRoute, private router: Router) {
    
  }

  ngOnInit() {
    console.log(this.activatedRoute.snapshot.paramMap.get("alpha2code"));
    this.alpha2Code = this.activatedRoute.snapshot.paramMap.get("alpha2code");
    console.log(this.alpha2Code);
    this.http.get<Country>(this.baseUrl + 'country?alpha2code=' + this.alpha2Code).subscribe(result => {
      this.country = result;
    },
    error => console.error(error)); //mostrar mensagem erro
    this.showButton = true;
  }

}

interface Country {
  id: number;
  countryName: string;
  alpha2Code: string;
  alpha3Code: string;
  numericCode: number;
  subDivisionCode: string;
  internetDomain: string;
}
