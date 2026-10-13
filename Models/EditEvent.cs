using System.Text.Json.Serialization;

namespace ExpressBot.Core.Models
{
    public class EditEvent
    {
        [JsonPropertyName("sync_id")]
        public Guid SyncId { get; set; }

        [JsonPropertyName("payload")]
        public Payload Payload { get; set; }

        [JsonPropertyName("file")]
        public File File { get; set; }

        [JsonPropertyName("opts")]
        public object Opts { get; set; }
    }

}
