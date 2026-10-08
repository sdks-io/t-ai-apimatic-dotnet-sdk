using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Weights &amp; Biases details associated with the training session
/// </summary>
public record RlWandbMetadata2
{
    /// <summary>
    /// Weights &amp; Biases username or team that owns the project
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    [MaxLength(256)]
    public string? Entity { get; init; }

    /// <summary>
    /// Weights &amp; Biases project containing the run
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("project")]
    [MaxLength(256)]
    public string? Project { get; init; }

    /// <summary>
    /// Weights &amp; Biases group used to organize related runs
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group")]
    [MaxLength(256)]
    public string? Group { get; init; }

    /// <summary>
    /// Human-readable name of the Weights &amp; Biases run
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("run_name")]
    [MaxLength(256)]
    public string? RunName { get; init; }

    /// <summary>
    /// Unique identifier assigned to the run by Weights &amp; Biases
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("run_id")]
    [MaxLength(256)]
    public string? RunId { get; init; }

    /// <summary>
    /// HTTPS URL for the Weights &amp; Biases run
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    [MaxLength(2048)]
    public string? Url { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
