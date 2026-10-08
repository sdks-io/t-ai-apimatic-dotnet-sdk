using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Available upon completion, the outputs provides the cost charged and the hosted url to access the video
/// </summary>
public record Outputs
{
    /// <summary>
    /// The cost of generated video charged to the owners account.
    /// </summary>
    [JsonPropertyName("cost")]
    public required int Cost { get; init; }

    /// <summary>
    /// URL hosting the generated video
    /// </summary>
    [JsonPropertyName("video_url")]
    public required string VideoUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
