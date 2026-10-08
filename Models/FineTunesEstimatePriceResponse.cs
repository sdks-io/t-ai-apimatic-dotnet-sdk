using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record FineTunesEstimatePriceResponse
{
    /// <summary>
    /// Whether price estimation is available for the requested fine-tune job.
    /// </summary>
    [JsonPropertyName("estimation_available")]
    public string EstimationAvailable { get; } = "True";

    /// <summary>
    /// The price of the fine-tuning job
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("estimated_total_price")]
    public double? EstimatedTotalPrice { get; init; }

    /// <summary>
    /// Whether you are allowed to proceed with the fine-tuning job.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowed_to_proceed")]
    public bool? AllowedToProceed { get; init; }

    /// <summary>
    /// Your credit limit in dollars.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_limit")]
    public double? UserLimit { get; init; }

    /// <summary>
    /// The estimated number of tokens to be trained
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("estimated_train_token_count")]
    public double? EstimatedTrainTokenCount { get; init; }

    /// <summary>
    /// The estimated number of tokens for evaluation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("estimated_eval_token_count")]
    public double? EstimatedEvalTokenCount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
