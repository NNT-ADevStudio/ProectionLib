using System;
using System.Text.Json.Serialization;

namespace ProectionLib.Models
{
    public class Testing
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("sentDate")]
        public string SentDate { get; set; }

        [JsonPropertyName("publishDate")]
        public string PublishDate { get; set; }

        [JsonPropertyName("finishDate")]
        public string FinishDate { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
