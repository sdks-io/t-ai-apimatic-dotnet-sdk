namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the GetInferenceCheckpointOperation operation.
/// </summary>
public sealed record GetInferenceCheckpointOperationRequest
{
    public required string SessionId { get; init; }

    public required string OperationId { get; init; }
}
