using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

public record EvaluationCompareParameters
{
    [JsonPropertyName("judge")]
    public required EvaluationJudgeModelConfig Judge { get; init; }

    /// <summary>
    /// Either an EvaluationModelRequest for generation or a string column name from the dataset (when responses are pre-generated). When both model_a and model_b are EvaluationModelRequest objects, their inference runs execute in parallel to reduce total wall-clock time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_a")]
    public ModelA? ModelA { get; init; }

    /// <summary>
    /// Either an EvaluationModelRequest for generation or a string column name from the dataset (when responses are pre-generated). When both model_a and model_b are EvaluationModelRequest objects, their inference runs execute in parallel to reduce total wall-clock time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_b")]
    public ModelB? ModelB { get; init; }

    /// <summary>
    /// Data file ID
    /// </summary>
    [JsonPropertyName("input_data_file_path")]
    public required string InputDataFilePath { get; init; }

    /// <summary>
    /// When false (default), the judge runs twice per sample: once with model A's response first (original order) and once with model B's response first (flipped order). The two verdicts are reconciled to cancel out position bias. When true, only the original-order pass is run, halving judge cost and latency at the expense of position-bias correction. The result file will not contain flipped-order judge fields when this is true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disable_position_bias_correction")]
    public bool? DisablePositionBiasCorrection { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
