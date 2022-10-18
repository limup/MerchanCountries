using MerchanCountriesAngular.Data.Repositories.Abstractions;
using MerchanCountriesAngular.Domain;
using Microsoft.AspNetCore.Mvc;

namespace MerchanCountriesAngular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MerchanCountriesAngularController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;

        public MerchanCountriesAngularController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Country>> Get()
        {
           return await _countryRepository.GetAsync();
        }
    }
}