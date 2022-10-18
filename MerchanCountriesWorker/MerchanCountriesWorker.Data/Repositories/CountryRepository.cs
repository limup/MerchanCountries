using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerchanCountriesWorker.Core.Models;
using MerchanCountriesWorker.Data.Repositories.Abstractions;
using MerchanCountriesWorker.Domain;

namespace MerchanCountriesWorker.Data.Repositories
{
    public class CountryRepository : RepositoryBase<Country>, ICountryRepository
    {
        public CountryRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}