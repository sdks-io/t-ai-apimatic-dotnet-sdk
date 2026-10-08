namespace TogetherApIs.Requests.ConfigService;

/// <summary>
/// The inputs of the ConfigServiceGetProjectConfig operation.
/// </summary>
public sealed record ConfigServiceGetProjectConfigRequest
{
    public required string ProjectId { get; init; }

    public required string Id { get; init; }
}
