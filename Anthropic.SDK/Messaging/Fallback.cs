using System.Text.Json.Serialization;

namespace Anthropic.SDK.Messaging
{
    /// <summary>
    /// A server-side fallback target. Names a model and may override
    /// <c>max_tokens</c> and <c>thinking</c> for that attempt only.
    /// </summary>
    public class Fallback
    {
        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        [JsonPropertyName("thinking")]
        public ThinkingParameters Thinking { get; set; }
    }
}
