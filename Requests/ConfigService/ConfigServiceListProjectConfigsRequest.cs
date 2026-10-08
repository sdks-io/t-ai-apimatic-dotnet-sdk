namespace TogetherApIs.Requests.ConfigService;

/// <summary>
/// The inputs of the ConfigServiceListProjectConfigs operation.
/// </summary>
public sealed record ConfigServiceListProjectConfigsRequest
{
    public required string ProjectId { get; init; }

    public string? ReferenceModelId { get; init; }

    public string? ReferenceModel { get; init; }

    public int? Limit { get; init; }

    public string? After { get; init; }
}
