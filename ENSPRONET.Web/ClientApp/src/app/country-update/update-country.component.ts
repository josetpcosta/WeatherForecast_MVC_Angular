import { HttpClient } from "@angular/common/http";
import { Component, Inject } from "@angular/core";
import { FormControl, FormGroup } from "@angular/forms";
import { ActivatedRoute, Router } from "@angular/router";

@Component({
    selector: 'update-country',
    templateUrl: './update-country.component.html'
})

export class CountryUpdateComponent {
    public countryUpdateForm: FormGroup;

    private alpha2Code: string | null = "";
    public successRequest: boolean = false;
    public errorRequest: boolean = false;

    private countryReadModel: countryReadModel = {
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
        this.countryUpdateForm = new FormGroup({
            countryName: new FormControl(""),
            alpha2Code: new FormControl(""),
            alpha3Code: new FormControl(""),
            numericCode: new FormControl(""),
            id: new FormControl(""),
        });
    }


    ngOnInit() {

        this.alpha2Code = this.activatedRoute.snapshot.paramMap.get("alpha2code");
        this.http.get<countryReadModel>(this.baseUrl + 'country?alpha2code=' + this.alpha2Code).subscribe(result => {
            this.countryReadModel = result;
            this.countryUpdateForm.patchValue({
                countryName: this.countryReadModel.countryName,
                alpha2Code: this.countryReadModel.alpha2Code,
                alpha3Code: this.countryReadModel.alpha3Code,
                numericCode: this.countryReadModel.numericCode,
                countryID: this.countryReadModel.id
            });
        });
    }

    onSubmit() {
        this.http.put(this.baseUrl + 'country?id=' + this.countryReadModel.id, this.countryUpdateForm.value).subscribe(result => {
            this.successRequest = true;
        }, error => { this.errorRequest = true; });
      }
}

interface countryReadModel {
    id: number;
    countryName: string;
    alpha2Code: string;
    alpha3Code: string;
    numericCode: number;
    subDivisionCode: string;
    internetDomain: string;
    summary: string;
}