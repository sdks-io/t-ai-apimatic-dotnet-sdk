namespace TogetherApIs.Requests.Deployments;

/// <summary>
/// The inputs of the ListRevisionHistoryEventsOfADeployment operation.
/// </summary>
public sealed record ListRevisionHistoryEventsOfADeploymentRequest
{
    public required string Id { get; init; }

    public int? Limit { get; init; }

    public int? Before { get; init; }
}
