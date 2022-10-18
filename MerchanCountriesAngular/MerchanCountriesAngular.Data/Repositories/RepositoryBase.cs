using System.Text.Json;
using MerchanCountriesAngular.Core.Models;
using MerchanCountriesAngular.Data.Repositories.Abstractions;
using MerchanCountriesAngular.Domain;

namespace MerchanCountriesAngular.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RepositoryBase(IHttpClientFactory httpClientFactory)=>
        (_httpClientFactory) = (httpClientFactory);

        /// <summary>
        /// Get all datas of datasource
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            IEnumerable<TEntity> countries = await DoHttpClient(_httpClientFactory.CreateClient("RestCountries"));
            return countries;
        }

        public async Task<IEnumerable<TEntity>?> DoHttpClient(HttpClient httpClient)
        {
            var httpResponseMessage = await httpClient.GetAsync("MerchanCountries");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();

                return await JsonSerializer.DeserializeAsync
                 <IEnumerable<TEntity>>(contentStream);
            }
            else
            {
                return null;
            }
        }
    }
}