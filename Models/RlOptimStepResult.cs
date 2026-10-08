using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

/// <summary>
/// Result of an optimizer step operation
/// </summary>
public record RlOptimStepResult
{
    /// <summary>
    /// Step number
    /// </summary>
    [JsonPropertyName("step")]
    public required Step Step { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
