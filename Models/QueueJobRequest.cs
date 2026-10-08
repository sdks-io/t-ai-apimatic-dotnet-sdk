using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Request to submit a job to the queue.
/// </summary>
public record QueueJobRequest
{
    /// <summary>
    /// Arbitrary JSON metadata stored with the job. Returned in status
    /// responses, where the model and system may have added or modified
    /// keys (e.g. progress).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("info")]
    public object? Info { get; init; }

    /// <summary>
    /// Required model identifier
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Freeform model input. Passed unchanged to the model. Contents are model-specific.
    /// </summary>
    [JsonPropertyName("payload")]
    public required object Payload { get; init; }

    /// <summary>
    /// Job priority. Higher values are processed first (strict priority
    /// ordering). Jobs with equal priority are processed in submission
    /// order (FIFO).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priority")]
    public int? Priority { get; init; } = 0;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
