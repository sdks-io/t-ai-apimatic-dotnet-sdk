using TogetherApIs.Models;

namespace TogetherApIs.Requests.FineTuning;

/// <summary>
/// The inputs of the EstimatePrice operation.
/// </summary>
public sealed record EstimatePriceRequest
{
    public required FineTunesEstimatePriceRequest Body { get; init; }
}
