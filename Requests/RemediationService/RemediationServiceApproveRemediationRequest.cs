using TogetherApIs.Models;

namespace TogetherApIs.Requests.RemediationService;

/// <summary>
/// The inputs of the RemediationServiceApproveRemediation operation.
/// </summary>
public sealed record RemediationServiceApproveRemediationRequest
{
    public required string ClusterId { get; init; }

    public required string InstanceId { get; init; }

    public required string RemediationId { get; init; }

    public required ApproveRemediationRequest Body { get; init; }
}
