using Dapper;
using NessusClient.DTO;
using System.Data.SqlClient;
using System.Globalization;

namespace NessusClient.Services
{
    public class DatabaseService
    {
        public void InsertResult(NessusClientData_v2 nessusClientData)
        {
            foreach (var host in nessusClientData.Report.ReportHost)
            {
                foreach (var item in host.ReportItem)
                {
                    var hostName = host.name;
                    var scanDateOriginalFormat = host.HostProperties.FirstOrDefault(x => x.name == "HOST_END").Value;
                    var scanDate = DateTime.ParseExact(scanDateOriginalFormat, "ddd MMM dd HH:mm:ss yyyy", CultureInfo.InvariantCulture);
                    var outputLong = item.Items.Last().ToString();
                    var output = outputLong.Substring(0, Math.Min(outputLong.Length, 300));
                    var severity = item.severity;

                    using (var conn = new SqlConnection(Settings.AppSettings.DatabaseConnectionString))
                    {
                        conn.Execute("INSERT INTO [dbo].[ScanResuls] ([HostName],[ScanDate],[Output],[Severity]) " +
                            "VALUES (@hostName, @scanDate, @output, @severity)", new { hostName, scanDate, output, severity });
                    }

                }
            }
        }

        public IEnumerable<Models.Result> GetResult()
        {
            using (var conn = new SqlConnection(Settings.AppSettings.DatabaseConnectionString))
            {
                return conn.Query<Models.Result>("SELECT * FROM [Nessus].[dbo].[ScanResuls]");
            }
        }

        public void DeleteResult(int id)
        {
            using (var conn = new SqlConnection(Settings.AppSettings.DatabaseConnectionString))
            {
                conn.Execute("Delete FROM [Nessus].[dbo].[ScanResuls] where Id = @id", new { id });
            }
        }
    }
}
