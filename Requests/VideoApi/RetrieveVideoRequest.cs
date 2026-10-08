namespace TogetherApIs.Requests.VideoApi;

/// <summary>
/// The inputs of the RetrieveVideo operation.
/// </summary>
public sealed record RetrieveVideoRequest
{
    public required string Id { get; init; }
}
