namespace TogetherApIs.Requests.Evaluation;

/// <summary>
/// The inputs of the GetEvaluationJobStatusAndResults operation.
/// </summary>
public sealed record GetEvaluationJobStatusAndResultsRequest
{
    public required string Id { get; init; }
}
