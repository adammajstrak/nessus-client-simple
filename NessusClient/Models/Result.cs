namespace NessusClient.Models
{
    public class Result
    {
        public int Id { get; set; }
        public string HostName { get; set; }
        public string ScanDate { get; set; }
        public string Output { get; set; }
        public string Severity { get; set; }
    }
}
