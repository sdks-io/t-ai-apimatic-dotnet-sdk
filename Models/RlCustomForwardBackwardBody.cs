using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Request body for a custom forward-backward pass.
/// </summary>
public record RlCustomForwardBackwardBody
{
    /// <summary>
    /// Batch of training samples
    /// </summary>
    [JsonPropertyName("samples")]
    public required IReadOnlyList<RlTrainingSample> Samples { get; init; }

    /// <summary>
    /// Per-sample per-token gradients of the loss with respect to log-probabilities
    /// </summary>
    [JsonPropertyName("gradients")]
    public required IReadOnlyList<RlTargetLogprobGradients> Gradients { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
