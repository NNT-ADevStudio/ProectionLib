using System;
using System.Net.Http;

namespace ProectionLib.Models.HelperModels
{
    public static class Configurate
    {
        public const string defaultBaseUrl = "https://api.proaction.pro/api/";

        public static HttpClient GetHttpClient(string apiKey, int timeoutMs = 60000, string baseUrl = null)
        {
            if (baseUrl == null)
                baseUrl = defaultBaseUrl;

            HttpClient HttpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl),
                Timeout = TimeSpan.FromMilliseconds(timeoutMs)
            };
            HttpClient.DefaultRequestHeaders.Add("X-Api-Key", apiKey);

            return HttpClient;
        }
    }
}
