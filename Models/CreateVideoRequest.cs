using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Validation.Attributes;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Parameters for creating a new video generation job.
/// </summary>
public record CreateVideoRequest
{
    /// <summary>
    /// The model to be used for the video creation request.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Text prompt that describes the video to generate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prompt")]
    [StringLength(32000, MinimumLength = 1)]
    public string? Prompt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("height")]
    public int? Height { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("width")]
    public int? Width { get; init; }

    /// <summary>
    /// Video resolution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resolution")]
    public string? Resolution { get; init; }

    /// <summary>
    /// Aspect ratio of the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratio")]
    public string? Ratio { get; init; }

    /// <summary>
    /// Clip duration in seconds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seconds")]
    public string? Seconds { get; init; }

    /// <summary>
    /// Frames per second. Defaults to 24.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fps")]
    public int? Fps { get; init; }

    /// <summary>
    /// The number of denoising steps the model performs during video generation. More steps typically result in higher quality output but require longer processing time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("steps")]
    [Minimum(10)]
    [Maximum(50)]
    public int? Steps { get; init; }

    /// <summary>
    /// Seed to use in initializing the video generation.  Using the same seed allows deterministic video generation.  If not provided a random seed is generated for each request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seed")]
    public int? Seed { get; init; }

    /// <summary>
    /// Controls how closely the video generation follows your prompt. Higher values make the model adhere more strictly to your text description, while lower values allow more creative freedom. guidence_scale affects both visual content and temporal consistency.Recommended range is 6.0-10.0 for most video models. Values above 12 may cause over-guidance artifacts or unnatural motion patterns.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("guidance_scale")]
    public int? GuidanceScale { get; init; }

    /// <summary>
    /// Specifies the format of the output video. Defaults to MP4.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("output_format")]
    public VideoOutputFormat2? OutputFormat { get; init; }

    /// <summary>
    /// Compression quality. Defaults to 20.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("output_quality")]
    public int? OutputQuality { get; init; }

    /// <summary>
    /// Similar to prompt, but specifies what to avoid instead of what to include
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("negative_prompt")]
    public string? NegativePrompt { get; init; }

    /// <summary>
    /// Whether to generate audio for the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generate_audio")]
    public bool? GenerateAudio { get; init; }

    /// <summary>
    /// Media inputs for video generation. The accepted fields depend on the model type (e.g. i2v, r2v, t2v, videoedit).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("media")]
    public VideoMedia2? Media { get; init; }

    /// <summary>
    /// Deprecated: use media.frame_images instead. Array of images to guide video generation, similar to keyframes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frame_images")]
    public IReadOnlyList<VideoFrameImageInput>? FrameImages { get; init; }

    /// <summary>
    /// Deprecated: use media.reference_images instead. Unlike frame_images which constrain specific timeline positions, reference images guide the general appearance that should appear consistently across the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_images")]
    public IReadOnlyList<string>? ReferenceImages { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
