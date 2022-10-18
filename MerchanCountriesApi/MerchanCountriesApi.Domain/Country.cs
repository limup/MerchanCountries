using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MerchanCountriesApi.Core.Models;
using Newtonsoft.Json;

namespace MerchanCountriesApi.Domain
{
    public class Country : Entity
    {
        public Country(Guid id) : base(id)
        {
        }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("cca2")]
        public string Cca2 { get; set; }

        [JsonPropertyName("currencies")]
        public Currencies Currencies { get; set; }

        [JsonPropertyName("capital")]
        public List<string> Capital { get; set; }

        [JsonPropertyName("languages")]
        public Languages Languages { get; set; }

        [JsonPropertyName("borders")]
        public List<string> Borders { get; set; }

        [JsonPropertyName("population")]
        public int Population { get; set; }

        [JsonPropertyName("timezones")]
        public List<string> Timezones { get; set; }

        [JsonPropertyName("flags")]
        public Flags Flags { get; set; }
    }
}