namespace TogetherApIs.Requests.Deployments;

/// <summary>
/// The inputs of the GetTheFullConfigurationOfASpecificRevision operation.
/// </summary>
public sealed record GetTheFullConfigurationOfASpecificRevisionRequest
{
    public required string Id { get; init; }

    public required string RevisionIdentifier { get; init; }
}
