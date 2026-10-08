using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

public record EvaluationClassifyParameters
{
    [JsonPropertyName("judge")]
    public required EvaluationJudgeModelConfig Judge { get; init; }

    /// <summary>
    /// List of possible classification labels
    /// </summary>
    [JsonPropertyName("labels")]
    [MinLength(2)]
    public required IReadOnlyList<string> Labels { get; init; }

    /// <summary>
    /// List of labels that are considered passing
    /// </summary>
    [JsonPropertyName("pass_labels")]
    [MinLength(1)]
    public required IReadOnlyList<string> PassLabels { get; init; }

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
