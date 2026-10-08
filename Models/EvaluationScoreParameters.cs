using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

public record EvaluationScoreParameters
{
    [JsonPropertyName("judge")]
    public required EvaluationJudgeModelConfig Judge { get; init; }

    /// <summary>
    /// Minimum possible score
    /// </summary>
    [JsonPropertyName("min_score")]
    public required double MinScore { get; init; }

    /// <summary>
    /// Maximum possible score
    /// </summary>
    [JsonPropertyName("max_score")]
    public required double MaxScore { get; init; }

    /// <summary>
    /// Score threshold for passing
    /// </summary>
    [JsonPropertyName("pass_threshold")]
    public required double PassThreshold { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_to_evaluate")]
    public EvaluationModelOrString? ModelToEvaluate { get; init; }

    /// <summary>
    /// Data file ID
    /// </summary>
    [JsonPropertyName("input_data_file_path")]
    public required string InputDataFilePath { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
