using TogetherApIs.Models;

namespace TogetherApIs.Requests.Evaluation;

/// <summary>
/// The inputs of the CreateEvaluationJob operation.
/// </summary>
public sealed record CreateEvaluationJobRequest
{
    public required EvaluationTypedRequest Body { get; init; }
}
