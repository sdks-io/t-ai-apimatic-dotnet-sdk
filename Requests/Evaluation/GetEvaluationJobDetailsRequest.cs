namespace TogetherApIs.Requests.Evaluation;

/// <summary>
/// The inputs of the GetEvaluationJobDetails operation.
/// </summary>
public sealed record GetEvaluationJobDetailsRequest
{
    public required string Id { get; init; }
}
