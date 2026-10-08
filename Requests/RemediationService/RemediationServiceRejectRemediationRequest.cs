using TogetherApIs.Models;

namespace TogetherApIs.Requests.RemediationService;

/// <summary>
/// The inputs of the RemediationServiceRejectRemediation operation.
/// </summary>
public sealed record RemediationServiceRejectRemediationRequest
{
    public required string ClusterId { get; init; }

    public required string InstanceId { get; init; }

    public required string RemediationId { get; init; }

    public required CommentBody Body { get; init; }
}
