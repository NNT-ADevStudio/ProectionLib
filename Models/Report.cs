using ProectionLib.Models.SubModels;
using System.Text.Json.Serialization;

namespace ProectionLib.Models
{
    public class Report
    {
        [JsonPropertyName("tested")]
        public TestedInfo Tested { get; set; }

        [JsonPropertyName("result")]
        public ResultInfo Result { get; set; }
    }
}
