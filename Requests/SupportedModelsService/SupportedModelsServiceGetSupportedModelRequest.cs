namespace TogetherApIs.Requests.SupportedModelsService;

/// <summary>
/// The inputs of the SupportedModelsServiceGetSupportedModel operation.
/// </summary>
public sealed record SupportedModelsServiceGetSupportedModelRequest
{
    public required string Id { get; init; }
}
