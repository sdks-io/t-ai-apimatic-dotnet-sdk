using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Reason, disposition, and optional concurrency check for canceling a rollout.
/// </summary>
public record DeCancelRolloutRequest
{
    /// <summary>
    /// Required human-readable reason recorded in the rollout audit trail.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; init; }

    /// <summary>
    /// Optional etag for optimistic concurrency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("etag")]
    public string? Etag { get; init; }

    /// <summary>
    /// Optional cancel behavior. Absent defaults to freeze, which preserves the current traffic split. Revert is removed and rejected with FAILED_PRECONDITION; cancel with freeze, then run a reverse rollout back to the source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disposition")]
    public Disposition? Disposition { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
