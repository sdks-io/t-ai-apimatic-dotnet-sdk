namespace TogetherApIs.Requests.VolumeService;

/// <summary>
/// The inputs of the VolumeServiceListRemoteModelUploadEvents operation.
/// </summary>
public sealed record VolumeServiceListRemoteModelUploadEventsRequest
{
    public required string ProjectId { get; init; }

    public required string Id { get; init; }

    public int? Limit { get; init; }

    public string? After { get; init; }
}
