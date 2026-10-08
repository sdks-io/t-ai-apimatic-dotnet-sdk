using TogetherApIs.Models;

namespace TogetherApIs.Requests.RemediationService;

/// <summary>
/// The inputs of the RemediationServiceCreateRemediation operation.
/// </summary>
public sealed record RemediationServiceCreateRemediationRequest
{
    public required string ClusterId { get; init; }

    public required string InstanceId { get; init; }

    public string? RemediationId { get; init; }

    public required Remediation Body { get; init; }
}
