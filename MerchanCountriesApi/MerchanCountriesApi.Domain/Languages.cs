using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MerchanCountriesApi.Domain
{
    public class Languages : Dictionary<string, string>
    {
        public string Language { get; set; }
    }
}