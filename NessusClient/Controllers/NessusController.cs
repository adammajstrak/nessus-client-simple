using Microsoft.AspNetCore.Mvc;
using NessusClient.Services;

namespace NessusClient.Controllers
{
    [ApiController]
    public class NessusController : ControllerBase
    {
        ScansService _scansService = new ScansService();
        DatabaseService _databaseService = new DatabaseService();

        [HttpGet("nessus/scans")]
        public IEnumerable<Models.Scan> GetAllScans()
        {
            var scans =  _scansService.GetScans();
            return scans;
        }

        [HttpPost("nessus/scans")]
        public void CreateScan()
        {
            _scansService.CreateBasicNetworkScan();
        }

        [HttpPost("nessus/scans/load")]
        public void LoadScan([FromBody]Models.Scan scan)
        {
            var result = _scansService.DownloadScan(scan.Id);
            _databaseService.InsertResult(result);
        }

        [HttpGet("nessus/results")]
        public IEnumerable<Models.Result> GetResults()
        {
            return _databaseService.GetResult();
        }

        [HttpDelete("nessus/results/{id}")]
        public void DeleteResult(int id)
        {
            _databaseService.DeleteResult(id);
        }
    }
}