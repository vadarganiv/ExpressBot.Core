using System.Text.Json.Serialization;

namespace ExpressBot.Core.Models
{
    public class Payload
    {

        [JsonPropertyName("status")]
        public string Status { get; set; } // "ok" | "error"

        [JsonPropertyName("body")]
        public string Body { get; set; }

        [JsonPropertyName("metadata")]
        public object Metadata { get; set; }

        [JsonPropertyName("opts")]
        public object Opts { get; set; }

        [JsonPropertyName("keyboard")]
        public List<List<KeyboardItem>> Keyboard { get; set; }

        [JsonPropertyName("bubble")]
        public List<List<KeyboardItem>> Bubble { get; set; }

        [JsonPropertyName("mentions")]
        public List<Mention> Mentions { get; set; }
    }

    public class Opts
    {
        [JsonPropertyName("silent_response")]
        public bool SilentResponse { get; set; }

        [JsonPropertyName("buttons_auto_adjust")]
        public bool ButtonsAutoAdjust { get; set; }
    }
}
