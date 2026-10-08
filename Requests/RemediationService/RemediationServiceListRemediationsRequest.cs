using System.Collections.Generic;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.RemediationService;

/// <summary>
/// The inputs of the RemediationServiceListRemediations operation.
/// </summary>
public sealed record RemediationServiceListRemediationsRequest
{
    public required string ClusterId { get; init; }

    public required string InstanceId { get; init; }

    public int? PageSize { get; init; }

    public string? PageToken { get; init; }

    public IReadOnlyList<State11>? State { get; init; }

    public string? OrderBy { get; init; }

    public IReadOnlyList<Trigger1>? Trigger { get; init; }

    public IReadOnlyList<Mode2>? Mode { get; init; }
}
