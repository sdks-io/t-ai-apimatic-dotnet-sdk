using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Request to cancel a queued job.
/// </summary>
public record QueueCancelRequest
{
    /// <summary>
    /// Model identifier the job was submitted to
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// The request ID returned from the submit endpoint
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
