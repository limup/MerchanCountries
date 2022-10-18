using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MerchanCountriesApi.Domain
{
    public class Flags
    {
        [JsonPropertyName("png")]
        public string Png { get; set; }

        [JsonPropertyName("svg")]
        public string Svg { get; set; }
    }
}