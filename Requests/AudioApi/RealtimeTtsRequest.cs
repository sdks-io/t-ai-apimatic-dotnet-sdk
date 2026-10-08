using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.AudioApi;

/// <summary>
/// The inputs of the RealtimeTts operation.
/// </summary>
public sealed record RealtimeTtsRequest
{
    public Model7Enum Model { get; init; } = Model7Enum.HexgradKokoro82M;

    public string? Voice { get; init; }

    public int MaxPartialLength { get; init; } = 250;

    public string Language { get; init; } = "en";
}
