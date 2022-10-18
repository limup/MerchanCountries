using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerchanCountriesApi.Core.Models;
using MerchanCountriesApi.Data.Repositories.Abstractions;
using MerchanCountriesApi.Domain;

namespace MerchanCountriesApi.Data.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly IRepositoryBase<Country> _repositoryBase;

        public CountryRepository(IMongoDBContext context, IRepositoryBase<Country> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public async Task<IEnumerable<Country>> GetAsync()
        {
            return await _repositoryBase.GetAsync();
        }
    }
}