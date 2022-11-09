import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { CountriesComponent } from './countries/countries.component';
import { TemperaturesComponent } from './temperatures/temperatures.component';
import { DeleteTemperatureComponent } from './delete-temperature/delete-temperature.component';
import { UpdateTemperatureComponent } from './update-temperature/update-temperature.component';
import { CountryUpdateComponent } from './country-update/update-country.component';
import { DeleteCountryComponent } from './delete-country/delete-country.component';
import { CountryInfoA2cComponent } from './country-info-a2c/country-info-a2c.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    CountriesComponent,
    TemperaturesComponent,
    DeleteTemperatureComponent,
    UpdateTemperatureComponent,
    CountryUpdateComponent,
    DeleteCountryComponent,
    CountryInfoA2cComponent
  ],

  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data/:countryName/:countryID', component: FetchDataComponent },
      { path: 'countries', component: CountriesComponent },
      { path: 'temperatures/:countryName/:countryID/:temperatureID', component: TemperaturesComponent },
      { path: 'delete-temperature/:countryName/:countryID/:temperatureID', component: DeleteTemperatureComponent },
      { path: 'update-temperature/:countryName/:countryID/:temperatureID', component: UpdateTemperatureComponent },
      { path: 'update-country/:alpha2code', component: CountryUpdateComponent },
      { path: 'delete-country/:alpha2code', component: DeleteCountryComponent },
      { path: 'country-info-a2c/:alpha2code', component: CountryInfoA2cComponent }

    ]),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
