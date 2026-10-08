using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Performance benchmarks for the profile, if available.
/// </summary>
public record DeSupportedModelPerformanceBenchmarks2
{
    /// <summary>
    /// Decoding throughput in tokens per second.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decodingSpeedTps")]
    public double? DecodingSpeedTps { get; init; }

    /// <summary>
    /// Time to first token in milliseconds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeToFirstTokenMs")]
    public int? TimeToFirstTokenMs { get; init; }

    /// <summary>
    /// Maximum context length supported by the profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxContextLength")]
    public string? MaxContextLength { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
