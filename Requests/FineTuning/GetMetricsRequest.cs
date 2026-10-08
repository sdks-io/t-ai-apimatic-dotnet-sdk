using System;

namespace TogetherApIs.Requests.FineTuning;

/// <summary>
/// The inputs of the GetMetrics operation.
/// </summary>
public sealed record GetMetricsRequest
{
    public required string Id { get; init; }

    /// <summary>
    /// Return only metrics with global_step &gt;= this value.
    /// </summary>
    public int? GlobalStepFrom { get; init; }

    /// <summary>
    /// Return only metrics with global_step &lt;= this value.
    /// </summary>
    public int? GlobalStepTo { get; init; }

    /// <summary>
    /// Return only metrics logged at or after this ISO-8601 timestamp.
    /// </summary>
    public DateTimeOffset? LoggedAtFrom { get; init; }

    /// <summary>
    /// Return only metrics logged at or before this ISO-8601 timestamp.
    /// </summary>
    public DateTimeOffset? LoggedAtTo { get; init; }

    /// <summary>
    /// Number of (uniformly sampled) train metrics to return.
    /// </summary>
    public int? Resolution { get; init; }
}
