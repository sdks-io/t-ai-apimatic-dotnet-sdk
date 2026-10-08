using TogetherApIs.Models;

namespace TogetherApIs.Requests.FineTuning;

/// <summary>
/// The inputs of the PreviewTokenizedData operation.
/// </summary>
public sealed record PreviewTokenizedDataRequest
{
    public required FineTunePreviewRequest Body { get; init; }
}
