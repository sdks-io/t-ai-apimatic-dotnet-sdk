using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record FineTunesModelsSupportedResponse
{
    /// <summary>
    /// List of supported model names.
    /// </summary>
    [JsonPropertyName("models")]
    public required IReadOnlyList<string> Models { get; init; }

    /// <summary>
    /// Supported models with parent model details.
    /// </summary>
    [JsonPropertyName("detailed_models")]
    public required IReadOnlyList<DetailedModel> DetailedModels { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
