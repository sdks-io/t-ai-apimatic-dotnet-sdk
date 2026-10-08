namespace TogetherApIs.Requests.SharedVolumeService;

/// <summary>
/// The inputs of the SharedVolumeServiceList operation.
/// </summary>
public sealed record SharedVolumeServiceListRequest
{
    public string? ProjectId { get; init; }
}
