using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Validation outcome for a fine-tune training file, produced by the
/// file validation pipeline.
/// </summary>
public record FileValidationReport
{
    /// <summary>
    /// Whether the file passed validation.
    /// </summary>
    [JsonPropertyName("valid")]
    public required bool Valid { get; init; }

    /// <summary>
    /// Detected dataset format (e.g. <c>CONVERSATION</c>, <c>INSTRUCTION</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataset_format")]
    public string? DatasetFormat { get; init; }

    /// <summary>
    /// Whether the dataset carries per-sample weights.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataset_has_sample_weights")]
    public bool? DatasetHasSampleWeights { get; init; }

    /// <summary>
    /// Whether the dataset carries per-message weights (only possible for <c>CONVERSATION</c> format).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataset_has_message_weights")]
    public bool? DatasetHasMessageWeights { get; init; }

    /// <summary>
    /// Whether the dataset contains multimodal content.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataset_is_multimodal")]
    public bool? DatasetIsMultimodal { get; init; }

    /// <summary>
    /// Whether the dataset contains tool-use messages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataset_has_tools")]
    public bool? DatasetHasTools { get; init; }

    /// <summary>
    /// Whether the dataset contains parallel tool-use messages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataset_has_parallel_tool_calls")]
    public bool? DatasetHasParallelToolCalls { get; init; }

    /// <summary>
    /// Whether the dataset contains reasoning content.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataset_has_reasoning")]
    public bool? DatasetHasReasoning { get; init; }

    /// <summary>
    /// Number of lines (records) in the dataset.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nlines")]
    public int? Nlines { get; init; }

    /// <summary>
    /// ID of the file this report describes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("file_id")]
    public string? FileId { get; init; }

    /// <summary>
    /// Category of validation failure.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_type")]
    public ErrorType? ErrorType { get; init; }

    /// <summary>
    /// Human-readable validation error message. Only present when
    /// <c>error_type</c> is set (i.e. user-correctable failures).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public string? Error { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
