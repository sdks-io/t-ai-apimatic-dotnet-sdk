using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Count of pending jobs canceled by the clear operation.
/// </summary>
public record QueueClearResponse
{
    /// <summary>
    /// Number of pending jobs that were canceled
    /// </summary>
    [JsonPropertyName("canceled_count")]
    public required int CanceledCount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
