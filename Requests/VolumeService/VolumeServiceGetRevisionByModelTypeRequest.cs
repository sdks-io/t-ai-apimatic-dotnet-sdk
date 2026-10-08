namespace TogetherApIs.Requests.VolumeService;

/// <summary>
/// The inputs of the VolumeServiceGetRevisionByModelType operation.
/// </summary>
public sealed record VolumeServiceGetRevisionByModelTypeRequest
{
    public required string ProjectId { get; init; }

    public required string Id { get; init; }

    public required string RevisionId { get; init; }
}
