using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

public record DeCreateRolloutRequest
{
    /// <summary>
    /// Deployment that traffic shifts away from.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceDeploymentId")]
    public string? SourceDeploymentId { get; init; }

    /// <summary>
    /// Deployment that traffic shifts toward.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetDeploymentId")]
    public string? TargetDeploymentId { get; init; }

    /// <summary>
    /// Canary rollout strategy configuration. Mutually exclusive with blueGreen and rolling.
    /// </summary>
    [JsonPropertyName("canary")]
    public required DeCanaryConfig Canary { get; init; }

    /// <summary>
    /// Blue-green rollout strategy configuration. Mutually exclusive with canary and rolling.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("blueGreen")]
    public object? BlueGreen { get; init; }

    /// <summary>
    /// Rolling rollout strategy configuration. Mutually exclusive with canary and blueGreen.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rolling")]
    public object? Rolling { get; init; }

    /// <summary>
    /// Optional metric gates evaluated after each step's soak. Canary only; rejected on rolling and blue-green rollouts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metrics")]
    public IReadOnlyList<DeMetricRule2>? Metrics { get; init; }

    /// <summary>
    /// Optional final replica count for the source deployment. Defaults to 0, which drains and stops the source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("finalSourceReplicas")]
    public int? FinalSourceReplicas { get; init; }

    /// <summary>
    /// Optional target replica floor at completion. Must be at least 1 when set; defaults to the source deployment's replica count at create time, or to the source and target deployments' combined replica count when both already stand in the endpoint traffic split after a cancel. The completed target's autoscaling max lands at the landing ceiling, max(this value, the source max, the target's own max); the rollout may lift the target max at first wake, at the first step that needs it, or at completion unless an operator changes max mid-run. The lifted ceiling remains after completion, and PreviewRolloutDefaults reports a coming lift as ROLLOUT_WILL_RAISE_TARGET_MAX. A pre-existing target whose own autoscaling min is higher keeps that floor, reported as FINAL_BELOW_INHERITED_MIN. A target that starts stopped lands exactly at this value; if the source min was higher, PreviewRolloutDefaults reports FINAL_BELOW_SOURCE_MIN.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("finalTargetReplicas")]
    public int? FinalTargetReplicas { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
