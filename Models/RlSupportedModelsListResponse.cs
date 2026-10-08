using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// List of base models supported by the RL service
/// </summary>
public record RlSupportedModelsListResponse
{
    /// <summary>
    /// Supported base models for RL
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<RlSupportedModel> Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
