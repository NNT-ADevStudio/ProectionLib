using System.Net.Http;

namespace ProectionLib.Models.HelperModels
{
    public class Auth
    {
        public string ApiKey { get; set; }

        public HttpClient HttpClient { get; private set; }

        public Auth(string apiKey)
        {
            ApiKey = apiKey;
            HttpClient = Configurate.GetHttpClient(apiKey);
        }

        public HttpClient GenerateHttpClient() 
        {
            return Configurate.GetHttpClient(ApiKey);
        }
    }
}
