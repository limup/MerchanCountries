using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerchanCountriesApi.Core.Models;
using MerchanCountriesApi.Domain;

namespace MerchanCountriesApi.Data.Repositories.Abstractions
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAsync();
    }
}