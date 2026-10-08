using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record EvaluationClassifyResults
{
    /// <summary>
    /// Number of failed generations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generation_fail_count")]
    public double? GenerationFailCount { get; init; }

    /// <summary>
    /// Number of failed judge generations
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("judge_fail_count")]
    public double? JudgeFailCount { get; init; }

    /// <summary>
    /// Number of invalid labels
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invalid_label_count")]
    public double? InvalidLabelCount { get; init; }

    /// <summary>
    /// Data File ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result_file_id")]
    public string? ResultFileId { get; init; }

    /// <summary>
    /// Pecentage of pass labels.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pass_percentage")]
    public double? PassPercentage { get; init; }

    /// <summary>
    /// JSON string representing label counts
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("label_counts")]
    public string? LabelCounts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
