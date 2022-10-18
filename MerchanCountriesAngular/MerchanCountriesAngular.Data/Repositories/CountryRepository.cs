using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerchanCountriesAngular.Core.Models;
using MerchanCountriesAngular.Data.Repositories.Abstractions;
using MerchanCountriesAngular.Domain;

namespace MerchanCountriesAngular.Data.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly IRepositoryBase<Country> _repositoryBase;
        private readonly IHttpClientFactory _httpClientFactory;

        public CountryRepository(IRepositoryBase<Country> repositoryBase, IHttpClientFactory httpClientFactory)
        {
            _repositoryBase = repositoryBase;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<Country>> GetAsync()
        {
            return await _repositoryBase.GetAsync();
        }
    }
}