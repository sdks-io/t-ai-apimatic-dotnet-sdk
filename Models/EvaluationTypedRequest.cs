using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record EvaluationTypedRequest
{
    /// <summary>
    /// The type of evaluation to perform
    /// </summary>
    [JsonPropertyName("type")]
    public required Type14 Type { get; init; }

    /// <summary>
    /// Type-specific parameters for the evaluation
    /// </summary>
    [JsonPropertyName("parameters")]
    public required Parameters Parameters { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
