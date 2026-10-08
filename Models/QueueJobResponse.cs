using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Response returned after queueing a job.
/// </summary>
public record QueueJobResponse
{
    /// <summary>
    /// Unique identifier for the submitted job. Use this to poll status or cancel.
    /// </summary>
    [JsonPropertyName("requestId")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
