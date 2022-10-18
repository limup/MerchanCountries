import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Country } from "src/app/models/country";

@Component({
    selector: 'app-countries-data',
    templateUrl: './countries.component.html'
})
export class CountriesComponent {
    public countries: Country[] = [];

    display = 'none';
    displayBorders = 'none';
    
    population = [];
    timezone = [];
    currenciesSymbol = [];
    language = [];
    capital = [];
    bordering = [];

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        http.get<Country[]>(baseUrl + 'merchancountriesangular').subscribe(result => {
            this.countries = result;
        }, error => console.error(error));
    }

    getCurrency(country: any){
        var teste = [];
        if (!country.currencies == null) {
            teste = country.currencies[Object.keys(country.currencies).map(i => i).flat().toString()].name;
        }
        return teste;

    }

    openModal(country: any) {
        this.display = 'block';

        this.population = country.population;
        this.timezone = country.timezones;
        this.currenciesSymbol = country.currencies[Object.keys(country.currencies).map(i => i).flat().toString()].symbol;
        this.language = country.languages[Object.keys(country.languages).map(i => i).flat().toString()];
        this.capital = country.capital;
        this.bordering = country.borders;
    }

    openModalTrade() {
        this.displayBorders = 'block';
    }

    onCloseHandled() {
        this.display = 'none';
    }

    onCloseTrade() {
        this.displayBorders = 'none';
    }
}
