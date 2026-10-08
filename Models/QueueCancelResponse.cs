using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Status returned after a cancel attempt.
/// </summary>
public record QueueCancelResponse
{
    /// <summary>
    /// Job status after the cancel attempt. Only pending jobs can be
    /// canceled. If the job is already running, done, or failed, the status
    /// is returned unchanged.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status9 Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
