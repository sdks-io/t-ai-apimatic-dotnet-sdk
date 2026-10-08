using System.Collections.Generic;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.HealthCheckService;

/// <summary>
/// The inputs of the HealthCheckServiceListPassiveHealthCheckAlerts operation.
/// </summary>
public sealed record HealthCheckServiceListPassiveHealthCheckAlertsRequest
{
    public string? IntentId { get; init; }

    public string? InstanceId { get; init; }

    public string? ClusterId { get; init; }

    public int PageSize { get; init; } = 50;

    public string? PageToken { get; init; }

    public Status14? Status { get; init; }

    public IReadOnlyList<SeverityFilter>? SeverityFilter { get; init; }

    public OrderBy OrderBy { get; init; } = OrderBy.PhcAlertOrderStartedAtDesc;
}
