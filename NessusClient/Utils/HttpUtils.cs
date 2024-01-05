using System.Net.Http.Json;
using System.Text.Json;
using System.Text;

namespace NessusClient.Utils
{
    public static class HttpUtils
    {
        public static StringContent CreateBody(object obj)
        {
            return new(JsonSerializer.Serialize(obj), Encoding.UTF8, "application/json");
        }
    }
}
