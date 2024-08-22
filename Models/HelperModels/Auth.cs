using System.Net.Http;

namespace ProectionLib.Models.HelperModels
{
    public class Auth
    {
        public string ApiKey { get; set; }

        public Auth(string apiKey)
        {
            ApiKey = apiKey;
        }

        public HttpClient GenerateHttpClient() 
        {
            return Configurate.GetHttpClient(ApiKey);
        }

        public HttpClient GenerateHttpClient(int timeoutMs)
        {
            return Configurate.GetHttpClient(ApiKey, timeoutMs);
        }
    }
}
