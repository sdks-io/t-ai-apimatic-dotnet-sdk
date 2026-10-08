using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.SupportedModelsService;

/// <summary>
/// The inputs of the SupportedModelsServiceListSupportedModels operation.
/// </summary>
public sealed record SupportedModelsServiceListSupportedModelsRequest
{
    public Modality? Modality { get; init; }

    public Product1? Product { get; init; }

    public string? Search { get; init; }

    public int? Limit { get; init; }

    public string? After { get; init; }
}
