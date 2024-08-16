using System.Text.Json.Serialization;

namespace ProectionLib.Models.SubModels
{
    public class ResultInfo
    {
        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("score")]
        public int? Score { get; set; }

        [JsonPropertyName("profileStatus")]
        public int ProfileStatus { get; set; }
    }
}
