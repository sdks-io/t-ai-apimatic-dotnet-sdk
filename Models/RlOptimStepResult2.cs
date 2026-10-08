using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

/// <summary>
/// Result on success
/// </summary>
public record RlOptimStepResult2
{
    /// <summary>
    /// Step number
    /// </summary>
    [JsonPropertyName("step")]
    public required Step Step { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
