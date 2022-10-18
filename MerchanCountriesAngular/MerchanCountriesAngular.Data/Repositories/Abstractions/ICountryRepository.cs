using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerchanCountriesAngular.Core.Models;
using MerchanCountriesAngular.Domain;

namespace MerchanCountriesAngular.Data.Repositories.Abstractions
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAsync();
    }
}