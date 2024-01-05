using NessusClient.JsonMappers;
using NessusClient.Utils;
using NessusClient.Settings;
using System.Xml.Serialization;
using NessusClient.DTO;

namespace NessusClient.Services
{
    public class ScansService : NessusBase
    {
        public IEnumerable<Models.Scan> GetScans()
        {
            return GetClient()
                     .Get(AppSettings.AddressBase + "/scans")
                     .MapScanResponse();
        }

        public void CreateBasicNetworkScan()
        {
            var body = new
            {
                uuid = AppSettings.NetworkScanUuid,
                settings = new
                {
                    name = "test - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    enabled = "true",
                    text_targets = "win10",
                    launch = "ONETIME",
                    launch_now = true
                }
            };

            GetClient().Post(AppSettings.AddressBase + "/scans", body);
        }

        public NessusClientData_v2 DownloadScan(int id)
        {
            var body = new
            {
                format = "nessus"
            };

            string token = GetClient().Post(AppSettings.AddressBase + "/scans/" + id + "/export", body).MapExportResponse();

            string file = GetClient().Get(AppSettings.AddressBase + "/tokens/" + token + "/download");

            return file.MapResultResponse();
        }
    }
}
