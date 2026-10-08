using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Additional model-specific parameters that fine-tune speech generation behavior.
/// </summary>
public record ExtraParams
{
    /// <summary>
    /// A list of pronunciation rules for specific characters or symbols. Each entry uses the format <c>"&lt;source&gt;/&lt;replacement&gt;"</c> (e.g., <c>["omg/oh my god"]</c>) to override how the model pronounces matching tokens.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pronunciation_dict")]
    public IReadOnlyList<string>? PronunciationDict { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
