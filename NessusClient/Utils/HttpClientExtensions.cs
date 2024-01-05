namespace NessusClient.Utils
{
    public static class HttpClientExtensions
    {
        public static string Get(this HttpClient client, string url)
        {
            var response = client.GetAsync(url).Result;

            response.EnsureSuccessStatusCode();

            return response.Content.ReadAsStringAsync().Result;
        }

        public static string Post(this HttpClient client, string url, object body)
        {
            var response = client.PostAsync(url, HttpUtils.CreateBody(body)).Result;

            response.EnsureSuccessStatusCode();

            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
