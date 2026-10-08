namespace TogetherApIs.Requests.ModelsApi;

/// <summary>
/// The inputs of the Models operation.
/// </summary>
public sealed record ModelsRequest
{
    public bool? Dedicated { get; init; }
}
