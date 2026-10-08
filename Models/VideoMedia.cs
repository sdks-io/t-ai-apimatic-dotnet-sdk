using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

/// <summary>
/// Contains all media inputs for video generation. Accepted fields depend on the model type.
/// </summary>
public record VideoMedia
{
    /// <summary>
    /// Array of images to guide video generation at specific timeline positions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frame_images")]
    public IReadOnlyList<VideoFrameImageInput>? FrameImages { get; init; }

    /// <summary>
    /// Array of video clips to use as starting clips.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frame_videos")]
    public IReadOnlyList<VideoRef>? FrameVideos { get; init; }

    /// <summary>
    /// Array of image URLs that guide the general appearance across the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_images")]
    public IReadOnlyList<string>? ReferenceImages { get; init; }

    /// <summary>
    /// Array of reference videos.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_videos")]
    public IReadOnlyList<VideoRef>? ReferenceVideos { get; init; }

    /// <summary>
    /// Source video to edit. Accepts a URL string or an object with a "video" key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_video")]
    public SourceVideo? SourceVideo { get; init; }

    /// <summary>
    /// Array of audio inputs. Each element accepts a URL string or an object with an "audio" key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("audio_inputs")]
    public IReadOnlyList<AudioInput>? AudioInputs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
