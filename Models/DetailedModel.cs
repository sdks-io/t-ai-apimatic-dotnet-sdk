using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record DetailedModel
{
    /// <summary>
    /// Supported model name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Parent model used for fine-tuning.
    /// </summary>
    [JsonPropertyName("parent_model")]
    public required string ParentModel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
