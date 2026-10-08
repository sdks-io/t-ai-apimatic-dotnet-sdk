namespace TogetherApIs.Requests.VolumeService;

/// <summary>
/// The inputs of the VolumeServiceListOrganizationModels operation.
/// </summary>
public sealed record VolumeServiceListOrganizationModelsRequest
{
    public required string OrganizationId { get; init; }

    public int? Limit { get; init; }

    public string? After { get; init; }
}
