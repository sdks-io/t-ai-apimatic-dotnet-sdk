namespace TogetherApIs.Requests.RemediationService;

/// <summary>
/// The inputs of the RemediationServiceCancelRemediation operation.
/// </summary>
public sealed record RemediationServiceCancelRemediationRequest
{
    public required string ClusterId { get; init; }

    public required string InstanceId { get; init; }

    public required string RemediationId { get; init; }
}
