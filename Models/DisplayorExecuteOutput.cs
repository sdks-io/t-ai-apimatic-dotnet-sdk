using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record DisplayorExecuteOutput
{
    [JsonPropertyName("data")]
    public required Data1 Data { get; init; }

    [JsonPropertyName("type")]
    public required Type8 Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
