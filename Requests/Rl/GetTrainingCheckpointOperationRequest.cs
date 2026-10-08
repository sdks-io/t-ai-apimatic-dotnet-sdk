namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the GetTrainingCheckpointOperation operation.
/// </summary>
public sealed record GetTrainingCheckpointOperationRequest
{
    public required string SessionId { get; init; }

    public required string OperationId { get; init; }
}
