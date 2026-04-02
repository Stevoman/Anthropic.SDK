using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Anthropic.SDK.Messaging
{

    public class ThinkingParameters
    {
        [JsonPropertyName("type")]
        public ThinkingType Type { get; set; } = ThinkingType.enabled;

        [JsonPropertyName("budget_tokens")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? BudgetTokens { get; set; }

        /// <summary>
        /// Controls how thinking content is returned in API responses.
        /// Use <see cref="ThinkingDisplay.omitted"/> to receive thinking blocks with an empty thinking field
        /// but with the signature preserved for multi-turn continuity. Billing is unchanged.
        /// Defaults to <see cref="ThinkingDisplay.summarized"/>.
        /// </summary>
        [JsonPropertyName("display")]
        public ThinkingDisplay Display { get; set; } = ThinkingDisplay.summarized;

        /// <summary>
        /// Indicates whether to use interleaved thinking mode which allows thinking tokens to exceed max_tokens
        /// </summary>
        [JsonIgnore]
        public bool UseInterleavedThinking { get; set; }

        /// <summary>
        /// The effort level to map to output_config.effort when using adaptive thinking
        /// </summary>
        [JsonIgnore]
        public ThinkingEffort? Effort { get; set; }
    }
}
