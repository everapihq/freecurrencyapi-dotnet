using System;
using System.IO;
using System.Net;

namespace freecurrencyapi.Helpers
{
    public class RequestHelper
    {
        public const string BaseUrl = "https://api.freecurrencyapi.com/v1/";

        public RequestHelper()
        {
        }

        public static string Status(string apiKey = null)
        {
            string url;
            url = BaseUrl + "/status?apikey=" + apiKey;

            return GetResponse(url);
        }

        public static string Currencies(string apiKey, string currencies)
        {
            string url;
            url = BaseUrl + "/currencies?currencies=" + currencies + "&apikey=" + apiKey;

            return GetResponse(url);
        }

        public static string Latest(string apiKey, string baseCurrency, string currencies)
        {
            string url;
            url = BaseUrl + "/latest?currencies=" + currencies + "&base_currency=" + baseCurrency + "&apikey=" + apiKey;

            return GetResponse(url);
        }

        public static string Historical(string apiKey, string date, string baseCurrency, string currencies)
        {
            string url;
            url = BaseUrl + "/historical?currencies=" + currencies + "&base_currency=" + baseCurrency + "&date=" + date + "&apikey=" + apiKey;

            return GetResponse(url);
        }

        private static string GetResponse(string url)
        {
            string jsonString;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            try
            {
                using (var response = (HttpWebResponse)request.GetResponse())
                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    jsonString = reader.ReadToEnd();
                }
            }
            catch (WebException e)
            {
                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;
                    Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
                    using (Stream data = response.GetResponseStream())
                    using (var reader = new StreamReader(data))
                    {
                        jsonString = reader.ReadToEnd();
                    }
                }
            }


            return jsonString;
        }
    }
}

