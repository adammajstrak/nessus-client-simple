using NessusClient.DTO;
using System.Text.Json;

namespace NessusClient.JsonMappers
{
    public static class ExportMapper
    {
        public static string MapExportResponse(this string jsonResponse)
        {
            var exportResponse = JsonSerializer.Deserialize<ExportResponse>(jsonResponse);

            var token = exportResponse.Token;

            return token;
        }
    }
}
