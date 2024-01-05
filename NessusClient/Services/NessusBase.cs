using NessusClient.Utils;
using NessusClient.JsonMappers;
using NessusClient.Settings;
namespace NessusClient.Services
{
    public class NessusBase
    {
        protected HttpClient GetClient()
        {
            var handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };

            var client =  new HttpClient(handler);

            var token = GetToken(client);

            client.DefaultRequestHeaders.Remove("X-Cookie");
            client.DefaultRequestHeaders.Add("X-Cookie", "token=" + token);

            return client;
        }


        private string GetToken(HttpClient client)
        {
            var body = new
            {
                username = AppSettings.User,
                password = AppSettings.Password
            };

            using HttpResponseMessage response = client.PostAsync(AppSettings.AddressBase + "/session", HttpUtils.CreateBody(body)).Result;

            response.EnsureSuccessStatusCode();

            var jsonResponse = response.Content.ReadAsStringAsync().Result;

            return jsonResponse.MapTokenResponse();
        }
    }
}
