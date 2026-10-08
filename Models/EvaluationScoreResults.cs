using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record EvaluationScoreResults
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aggregated_scores")]
    public AggregatedScores? AggregatedScores { get; init; }

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
    /// number of invalid scores generated from model
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invalid_score_count")]
    public double? InvalidScoreCount { get; init; }

    /// <summary>
    /// number of failed samples generated from model
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failed_samples")]
    public double? FailedSamples { get; init; }

    /// <summary>
    /// Data File ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result_file_id")]
    public string? ResultFileId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
