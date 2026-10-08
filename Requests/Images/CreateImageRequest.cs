using TogetherApIs.Models;

namespace TogetherApIs.Requests.Images;

/// <summary>
/// The inputs of the CreateImage operation.
/// </summary>
public sealed record CreateImageRequest
{
    public required ImagesGenerationsRequest Body { get; init; }
}
