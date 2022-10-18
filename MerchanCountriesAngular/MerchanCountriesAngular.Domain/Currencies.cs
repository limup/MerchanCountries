using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MerchanCountriesAngular.Domain
{
    public class Currencies : Dictionary<string, CurrencyCountry>
    {
        public CurrencyCountry currencyCountry { get; set; }
    }
}