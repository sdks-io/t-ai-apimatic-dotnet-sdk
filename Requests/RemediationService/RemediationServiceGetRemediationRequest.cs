namespace TogetherApIs.Requests.RemediationService;

/// <summary>
/// The inputs of the RemediationServiceGetRemediation operation.
/// </summary>
public sealed record RemediationServiceGetRemediationRequest
{
    public required string ClusterId { get; init; }

    public required string InstanceId { get; init; }

    public required string RemediationId { get; init; }
}
