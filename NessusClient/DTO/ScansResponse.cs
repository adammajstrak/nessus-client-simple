using System.Text.Json.Serialization;

namespace NessusClient.DTO
{
    public class ScansResponse
    {
        [JsonPropertyName("folders")]
        public Folder[] Folders { get; set; }

        [JsonPropertyName("scans")]
        public Scan[] Scans { get; set; }

        [JsonPropertyName("timestamp")]
        public int? Timestamp { get; set; }
    }

    public class Folder
    {
        [JsonPropertyName("unread_count")]
        public int? UnreadCount { get; set; }

        [JsonPropertyName("custom")]
        public int? Custom { get; set; }

        [JsonPropertyName("default_tag")]
        public int? DefaultTag { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }
    }

    public class Scan
    {
        [JsonPropertyName("folder_id")]
        public int? FolderId { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("read")]
        public bool? Read { get; set; }

        [JsonPropertyName("last_modification_date")]
        public int? LastModificationDate { get; set; }

        [JsonPropertyName("creation_date")]
        public int? CreationDate { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("shared")]
        public bool? Shared { get; set; }

        [JsonPropertyName("user_permissions")]
        public int? UserPermissions { get; set; }

        [JsonPropertyName("owner")]
        public string Owner { get; set; }

        [JsonPropertyName("timezone")]
        public object Timezone { get; set; }

        [JsonPropertyName("rrules")]
        public object RRules { get; set; }

        [JsonPropertyName("starttime")]
        public object StartTime { get; set; }

        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        [JsonPropertyName("control")]
        public bool? Control { get; set; }

        [JsonPropertyName("live_results")]
        public int? LiveResults { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}

