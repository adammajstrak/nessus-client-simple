using System.Text.Json.Serialization;

namespace NessusClient.DTO
{
    public class TokenResponse
    {
        [JsonPropertyName("md5sum_wizard_templates")]
        public string Md5sumWizardTemplates
        {
            get; set;
        }
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("md5sum_tenable_links")]
        public string Md5sumTenableLinks { get; set; }
    }
}
