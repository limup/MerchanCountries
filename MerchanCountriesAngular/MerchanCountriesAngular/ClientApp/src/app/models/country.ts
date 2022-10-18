import { Name } from "./name";
import { Currencies } from "./currencies";
import { Languages } from "./languages";
import { Flags } from "./flags";
import { Entity } from "./entity";

export interface Country extends Entity {
    name: Name;
    cca2: string;
    currencies: Currencies;
    capital: string[];
    languages: Languages;
    borders: string[];
    population: number;
    timezones: string[];
    flags: Flags;
}