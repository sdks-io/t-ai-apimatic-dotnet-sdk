using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record RlModelInput
{
    /// <summary>
    /// Input chunks for the model
    /// </summary>
    [JsonPropertyName("chunks")]
    public required IReadOnlyList<RlModelInputChunk> Chunks { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
