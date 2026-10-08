using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Rate limits applied after stabilization and before replica bounds.
/// </summary>
public record DeScalingRules
{
    /// <summary>
    /// Non-empty lists replace the existing policies. To clear policies, include
    /// <c>autoscaling.scaleDown.policies</c> or <c>autoscaling.scaleUp.policies</c> in the update mask
    /// and supply an empty scaling rules object or <c>policies: []</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("policies")]
    public IReadOnlyList<DeScalingPolicy>? Policies { get; init; }

    /// <summary>
    /// <c>SCALING_POLICY_SELECT_MIN</c> chooses the policy allowing the smallest replica change;
    /// <c>SCALING_POLICY_SELECT_MAX</c> chooses the largest. These are caps, not guaranteed changes.
    /// <c>SCALING_POLICY_SELECT_DISABLED</c> holds this direction steady while replica bounds still apply.
    /// Omitted preserves the existing selector on update. When no selector is configured,
    /// authored policies use MAX; with no policies configured, the platform defaults apply.
    /// To reset the selector, include <c>autoscaling.scaleDown.selectPolicy</c> or
    /// <c>autoscaling.scaleUp.selectPolicy</c> in the update mask and omit <c>selectPolicy</c>.
    /// Clear both policies and <c>selectPolicy</c> to restore inherited defaults.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selectPolicy")]
    public SelectPolicy? SelectPolicy { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
