using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Structured information describing a generated video job.
/// </summary>
public record VideoJob
{
    /// <summary>
    /// Unique identifier for the video job.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The object type, which is always video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public Object2? Object { get; init; }

    /// <summary>
    /// The video generation model that produced the job.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Current lifecycle status of the video job.
    /// </summary>
    [JsonPropertyName("status")]
    public required VideoStatus Status { get; init; }

    /// <summary>
    /// Unix timestamp (seconds) for when the job was created.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required double CreatedAt { get; init; }

    /// <summary>
    /// Unix timestamp (seconds) for when the job completed, if finished.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("completed_at")]
    public double? CompletedAt { get; init; }

    /// <summary>
    /// The resolution of the generated video.
    /// </summary>
    [JsonPropertyName("size")]
    public required string Size { get; init; }

    /// <summary>
    /// Duration of the generated clip in seconds.
    /// </summary>
    [JsonPropertyName("seconds")]
    public required string Seconds { get; init; }

    /// <summary>
    /// Error payload that explains why generation failed, if applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public Error1? Error { get; init; }

    /// <summary>
    /// Available upon completion, the outputs provides the cost charged and the hosted url to access the video
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outputs")]
    public Outputs? Outputs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
