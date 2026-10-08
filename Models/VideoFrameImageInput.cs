using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

public record VideoFrameImageInput
{
    /// <summary>
    /// URL path to hosted image that is used for a frame
    /// </summary>
    [JsonPropertyName("input_image")]
    public required string InputImage { get; init; }

    /// <summary>
    /// Optional param to specify where to insert the frame. If this is omitted, the following heuristics are applied:
    /// - frame_images size is one, frame is first.
    /// - If size is two, frames are first and last.
    /// - If size is larger, frames are first, last and evenly spaced between.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frame")]
    public Frame1? Frame { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
