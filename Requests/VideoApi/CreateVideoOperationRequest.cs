using TogetherApIs.Models;

namespace TogetherApIs.Requests.VideoApi;

/// <summary>
/// The inputs of the CreateVideo operation.
/// </summary>
public sealed record CreateVideoOperationRequest
{
    public CreateVideoRequest? Body { get; init; }
}
