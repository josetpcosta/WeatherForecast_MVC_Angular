import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-delete-country',
  templateUrl: './delete-country.component.html',
})

export class DeleteCountryComponent {

  private alpha2Code: string | null = "";
  public successRequest: boolean = false;
  public errorRequest: boolean = false;

  public countryReadModel: CountryReadModel = {
      id: 0,
      alpha2Code: "",
      alpha3Code: "",
      numericCode: 0,
      subDivisionCode: "",
      internetDomain: "",
      summary: "",
      countryName: "",
  };

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private activatedRoute: ActivatedRoute, private router: Router) {
  
  }


  ngOnInit() {

      this.alpha2Code = this.activatedRoute.snapshot.paramMap.get("alpha2code");
      this.http.get<CountryReadModel>(this.baseUrl + 'country?alpha2code=' + this.alpha2Code).subscribe(result => {
          this.countryReadModel = result;
      });
  }

  onClickDelete(id: number) {

    this.http.delete(this.baseUrl + 'country?id=' + id).subscribe(result => {
      this.successRequest = true;
      
    }, error => {
      this.errorRequest = true;
      this.successRequest = false;
    });
  }
}

interface CountryReadModel {
  id: number;
  countryName: string;
  alpha2Code: string;
  alpha3Code: string;
  numericCode: number;
  subDivisionCode: string;
  internetDomain: string;
  summary: string;
}
