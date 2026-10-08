using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Queue job counts for a model.
/// </summary>
public record QueueMetricsResponse
{
    /// <summary>
    /// Number of jobs currently being processed
    /// </summary>
    [JsonPropertyName("messages_running")]
    public required int MessagesRunning { get; init; }

    /// <summary>
    /// Number of jobs waiting to be claimed by a worker
    /// </summary>
    [JsonPropertyName("messages_waiting")]
    public required int MessagesWaiting { get; init; }

    /// <summary>
    /// Total number of active jobs (waiting + running)
    /// </summary>
    [JsonPropertyName("total_jobs")]
    public required int TotalJobs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
