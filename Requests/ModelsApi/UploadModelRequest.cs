using TogetherApIs.Models;

namespace TogetherApIs.Requests.ModelsApi;

/// <summary>
/// The inputs of the UploadModel operation.
/// </summary>
public sealed record UploadModelRequest
{
    public required ModelUploadRequest Body { get; init; }
}
