using System;

namespace TogetherApIs.Requests.EndpointService;

/// <summary>
/// The inputs of the EndpointServiceGetEndpointAnalytics operation.
/// </summary>
public sealed record EndpointServiceGetEndpointAnalyticsRequest
{
    public required string ProjectId { get; init; }

    public required string Id { get; init; }

    public string? DeploymentId { get; init; }

    public DateTimeOffset? StartTime { get; init; }

    public DateTimeOffset? EndTime { get; init; }

    public bool? IncludeTimeSeries { get; init; }

    public string? Granularity { get; init; }
}
