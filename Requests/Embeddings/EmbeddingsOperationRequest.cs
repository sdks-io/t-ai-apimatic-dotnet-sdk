using TogetherApIs.Models;

namespace TogetherApIs.Requests.Embeddings;

/// <summary>
/// The inputs of the EmbeddingsInvoke operation.
/// </summary>
public sealed record EmbeddingsOperationRequest
{
    public EmbeddingsRequest? Body { get; init; }
}
