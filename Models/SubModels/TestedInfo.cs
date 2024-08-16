using System.Text.Json.Serialization;

namespace ProectionLib.Models.SubModels
{
    public class TestedInfo
    {
        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }
    }
}
