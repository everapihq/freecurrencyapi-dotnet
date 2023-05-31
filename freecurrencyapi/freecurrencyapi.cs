using System;
using System.Data.SqlTypes;
using freecurrencyapi.Helpers;

namespace freecurrencyapi
{
    public class Freecurrencyapi
    {
        private string ApiKey { get; }

        public Freecurrencyapi()
        {
        }

        public Fxapi(string apiKey)
        {
            ApiKey = apiKey;
        }

        public string Status()
        {
            return RequestHelper.Status(ApiKey);
        }

        public string Currencies(string currencies = "")
        {
            return RequestHelper.Currencies(ApiKey, currencies);
        }

        public string Latest(string baseCurrency = "USD", string currencies = "")
        {
            return RequestHelper.Latest(ApiKey, baseCurrency, currencies);
        }

        public string Historical(string data, string baseCurrency = "USD", string currencies = "")
        {
            return RequestHelper.Historical(ApiKey, data, baseCurrency, currencies);
        }
    }
}

