using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record RlTrainingSample
{
    /// <summary>
    /// Model input
    /// </summary>
    [JsonPropertyName("model_input")]
    public required RlModelInput1 ModelInput { get; init; }

    /// <summary>
    /// Per-token loss tensors keyed by name. Include <c>target_tokens</c> and the inputs required by the selected loss. Each tensor must declare <c>int64</c> or <c>float32</c>, be one-dimensional, and have the same length.
    /// </summary>
    [JsonPropertyName("loss_fn_inputs")]
    public required IReadOnlyDictionary<string, RlTensorData> LossFnInputs { get; init; }

    /// <summary>
    /// Opaque key returned with a sampled sequence. Pass it unchanged with the corresponding training sample to reuse the same expert selections. The selections must cover the entire training sample or all but its final token. Training fails if the key is no longer available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routed_experts_key")]
    [StringLength(256, MinimumLength = 1)]
    [RegularExpression("^routing/[A-Za-z0-9._-]+/[0-9a-f]{32}\\.[1-9][0-9]*$")]
    public string? RoutedExpertsKey { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
