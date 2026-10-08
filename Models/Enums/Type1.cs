using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Whether <c>value</c> is a replica count or a percentage of the replica count at the start
/// of the trailing period. Scaling events within that period count against the allowance;
/// percentages are rounded to whole replicas.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type1>))]
public sealed record Type1 : OpenStringEnum<Type1>
{
    private Type1(string value) : base(value)
    {
    }

    public static readonly Type1 ScalingPolicyTypePods = new("SCALING_POLICY_TYPE_PODS");

    public static readonly Type1 ScalingPolicyTypePercent = new("SCALING_POLICY_TYPE_PERCENT");

    public TResult Match<TResult>(Func<TResult> onScalingPolicyTypePods,
        Func<TResult> onScalingPolicyTypePercent,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ScalingPolicyTypePods => onScalingPolicyTypePods(),
            _ when this == ScalingPolicyTypePercent => onScalingPolicyTypePercent(),
            _ => otherwise(Value)
        };

    public void Match(Action onScalingPolicyTypePods, Action onScalingPolicyTypePercent, Action<string> otherwise)
    {
        if (this == ScalingPolicyTypePods) onScalingPolicyTypePods();
        else if (this == ScalingPolicyTypePercent) onScalingPolicyTypePercent();
        else otherwise(Value);
    }
}
