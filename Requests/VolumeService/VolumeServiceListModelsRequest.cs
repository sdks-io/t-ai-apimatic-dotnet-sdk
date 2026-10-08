using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.VolumeService;

/// <summary>
/// The inputs of the VolumeServiceListModels operation.
/// </summary>
public sealed record VolumeServiceListModelsRequest
{
    public required string ProjectId { get; init; }

    public Visibility5? Visibility { get; init; }

    public string? OrganizationId { get; init; }

    public int? Limit { get; init; }

    public string? After { get; init; }
}
