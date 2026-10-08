using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record RlForwardBackwardBody
{
    /// <summary>
    /// Batch of training samples to process
    /// </summary>
    [JsonPropertyName("samples")]
    public required IReadOnlyList<RlTrainingSample> Samples { get; init; }

    /// <summary>
    /// Loss function configuration
    /// </summary>
    [JsonPropertyName("loss")]
    public required RlLossConfig2 Loss { get; init; }

    /// <summary>
    /// Return the loss function's per-sample output tensors alongside the loss and metrics. Defaults to false. Enabling it increases the response size substantially for large batches and reduces step throughput, so leave it unset for ordinary training steps.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_loss_fn_outputs")]
    public bool? ReturnLossFnOutputs { get; init; }

    /// <summary>
    /// Run the forward pass only: report the loss and metrics, and the per-sample outputs when requested, without accumulating gradients. Defaults to false. Pair it with <c>return_loss_fn_outputs</c> to score a batch and read back its per-token log-probabilities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forward_only")]
    public bool? ForwardOnly { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
