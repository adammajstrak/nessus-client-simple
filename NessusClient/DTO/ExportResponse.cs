using System.Text.Json.Serialization;

namespace NessusClient.DTO
{

    public class ExportResponse
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("file")]
        public int File { get; set; }
    }

}
