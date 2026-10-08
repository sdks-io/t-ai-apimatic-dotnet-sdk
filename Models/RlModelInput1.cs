using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Model input
/// </summary>
public record RlModelInput1
{
    /// <summary>
    /// Input chunks for the model
    /// </summary>
    [JsonPropertyName("chunks")]
    public required IReadOnlyList<RlModelInputChunk> Chunks { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
