namespace TogetherApIs.Requests.FineTuning;

/// <summary>
/// The inputs of the GetModelLimits operation.
/// </summary>
public sealed record GetModelLimitsRequest
{
    public required string ModelName { get; init; }
}
