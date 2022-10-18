using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerchanCountriesApi.Data.Repositories.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace MerchanCountriesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MerchanCountriesController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;

        public MerchanCountriesController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Domain.Country>> Get()
        {
            var countries = await _countryRepository.GetAsync();
            return countries; //How we have many registers, I select to get 10 rows.
        }
    }
}