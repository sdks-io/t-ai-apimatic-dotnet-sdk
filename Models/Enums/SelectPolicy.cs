using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<SelectPolicy>))]
public sealed record SelectPolicy : OpenStringEnum<SelectPolicy>
{
    private SelectPolicy(string value) : base(value)
    {
    }

    public static readonly SelectPolicy ScalingPolicySelectMax = new("SCALING_POLICY_SELECT_MAX");

    public static readonly SelectPolicy ScalingPolicySelectMin = new("SCALING_POLICY_SELECT_MIN");

    public static readonly SelectPolicy ScalingPolicySelectDisabled = new("SCALING_POLICY_SELECT_DISABLED");

    public TResult Match<TResult>(Func<TResult> onScalingPolicySelectMax,
        Func<TResult> onScalingPolicySelectMin,
        Func<TResult> onScalingPolicySelectDisabled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ScalingPolicySelectMax => onScalingPolicySelectMax(),
            _ when this == ScalingPolicySelectMin => onScalingPolicySelectMin(),
            _ when this == ScalingPolicySelectDisabled => onScalingPolicySelectDisabled(),
            _ => otherwise(Value)
        };

    public void Match(Action onScalingPolicySelectMax,
        Action onScalingPolicySelectMin,
        Action onScalingPolicySelectDisabled,
        Action<string> otherwise)
    {
        if (this == ScalingPolicySelectMax) onScalingPolicySelectMax();
        else if (this == ScalingPolicySelectMin) onScalingPolicySelectMin();
        else if (this == ScalingPolicySelectDisabled) onScalingPolicySelectDisabled();
        else otherwise(Value);
    }
}
