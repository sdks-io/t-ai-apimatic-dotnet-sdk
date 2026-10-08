using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record EvaluationCompareResults
{
    /// <summary>
    /// Number of samples where model A was judged the winner
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("A_wins")]
    public int? AWins { get; init; }

    /// <summary>
    /// Number of samples where model B was judged the winner
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("B_wins")]
    public int? BWins { get; init; }

    /// <summary>
    /// Number of samples that resulted in a tie score
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Ties")]
    public int? Ties { get; init; }

    /// <summary>
    /// Number of generation failures across model A and model B.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generation_fail_count")]
    public double? GenerationFailCount { get; init; }

    /// <summary>
    /// Number of judge inference failures. In the default two-pass mode (disable_position_bias_correction=false) this is the combined failure count from both the original-order and flipped-order judge passes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("judge_fail_count")]
    public double? JudgeFailCount { get; init; }

    /// <summary>
    /// File ID of the detailed output file. Each row contains the original input fields plus judge outputs. In two-pass mode the file includes both original-order and flipped-order judge fields; in single-pass mode (disable_position_bias_correction=true) only original-order fields are present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result_file_id")]
    public string? ResultFileId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
