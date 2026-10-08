namespace TogetherApIs.Requests.Evaluation;

/// <summary>
/// The inputs of the GetAllEvaluationJobs operation.
/// </summary>
public sealed record GetAllEvaluationJobsRequest
{
    public string? Status { get; init; }

    public int Limit { get; init; } = 10;
}
