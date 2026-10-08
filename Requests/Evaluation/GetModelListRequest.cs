namespace TogetherApIs.Requests.Evaluation;

/// <summary>
/// The inputs of the GetModelList operation.
/// </summary>
public sealed record GetModelListRequest
{
    public string ModelSource { get; init; } = "all";
}
