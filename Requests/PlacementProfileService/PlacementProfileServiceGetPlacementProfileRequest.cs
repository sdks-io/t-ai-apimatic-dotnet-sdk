namespace TogetherApIs.Requests.PlacementProfileService;

/// <summary>
/// The inputs of the PlacementProfileServiceGetPlacementProfile operation.
/// </summary>
public sealed record PlacementProfileServiceGetPlacementProfileRequest
{
    public required string ProjectId { get; init; }

    public required string Id { get; init; }
}
