namespace TogetherApIs.Requests.Hardware;

/// <summary>
/// The inputs of the ListHardware operation.
/// </summary>
public sealed record ListHardwareRequest
{
    public string? Model { get; init; }
}
