using System.Text.Json.Serialization;

namespace Anthropic.SDK.Messaging;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ThinkingDisplay
{
    /// <summary>
    /// Thinking blocks contain summarized thinking text. This is the default.
    /// </summary>
    summarized,

    /// <summary>
    /// Thinking blocks are returned with an empty thinking field. The signature field
    /// still carries the encrypted full thinking for multi-turn continuity.
    /// </summary>
    omitted
}
