using TogetherApIs.Models;

namespace TogetherApIs.Requests.Rerank;

/// <summary>
/// The inputs of the RerankInvoke operation.
/// </summary>
public sealed record RerankOperationRequest
{
    public RerankRequest? Body { get; init; }
}
