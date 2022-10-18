using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerchanCountriesWorker.Core.Models;
using MerchanCountriesWorker.Domain;

namespace MerchanCountriesWorker.Data.Repositories.Abstractions
{
    public interface ICountryRepository : IRepositoryBase<Country>
    {
        
    }
}