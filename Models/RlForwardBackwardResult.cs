using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Result of a scored forward or forward-backward operation
/// </summary>
public record RlForwardBackwardResult
{
    /// <summary>
    /// Loss value
    /// </summary>
    [JsonPropertyName("loss")]
    public required double Loss { get; init; }

    /// <summary>
    /// Loss-specific metrics (e.g., KL divergence, clip fraction for GRPO)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metrics")]
    public IReadOnlyDictionary<string, double>? Metrics { get; init; }

    /// <summary>
    /// Per-sample loss function outputs, in request order. Empty unless the request set <c>return_loss_fn_outputs</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loss_fn_outputs")]
    public IReadOnlyList<RlLossFnOutput>? LossFnOutputs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
