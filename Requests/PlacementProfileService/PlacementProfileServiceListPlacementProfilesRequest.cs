namespace TogetherApIs.Requests.PlacementProfileService;

/// <summary>
/// The inputs of the PlacementProfileServiceListPlacementProfiles operation.
/// </summary>
public sealed record PlacementProfileServiceListPlacementProfilesRequest
{
    public required string ProjectId { get; init; }

    public int? Limit { get; init; }

    public string? After { get; init; }
}
