using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Output tensors produced by the loss function for one sample.
/// </summary>
public record RlLossFnOutput
{
    /// <summary>
    /// Output tensors keyed by name. Built-in losses return <c>logprobs</c>: the model's float32 per-token log-probabilities under the current policy, one value per token of the sample's input. Positions excluded from the loss, such as zero-weight positions, are masked to zero rather than true log-probabilities.
    /// </summary>
    [JsonPropertyName("tensors")]
    public required IReadOnlyDictionary<string, RlTensorData> Tensors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
