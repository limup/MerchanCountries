using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MerchanCountriesApi.Domain
{
    public class Name
    {
        [JsonPropertyName("common")]
        public string Common { get; set; }
    }
}