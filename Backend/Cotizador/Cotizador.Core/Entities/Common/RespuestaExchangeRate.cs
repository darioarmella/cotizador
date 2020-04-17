using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Cotizador.Core.Entities.Common
{
    public class RespuestaExchangeRate
    {
        public string Result { get; set; }

        public Uri Documentation { get; set; }

        public Uri TermsOfUse { get; set; }

        public string TimeZone { get; set; }

        public long TimeLastUpdate { get; set; }

        public long TimeNextUpdate { get; set; }

        public string Base { get; set; }

        [JsonProperty("conversion_rates")]
        public Dictionary<string, double> ConversionRates { get; set; }
    }
}
