using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Derived serving state, active when the experiment has at least one target.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State5>))]
public sealed record State5 : OpenStringEnum<State5>
{
    private State5(string value) : base(value)
    {
    }

    public static readonly State5 ShadowExperimentStateActive = new("SHADOW_EXPERIMENT_STATE_ACTIVE");

    public static readonly State5 ShadowExperimentStateInactive = new("SHADOW_EXPERIMENT_STATE_INACTIVE");

    public TResult Match<TResult>(Func<TResult> onShadowExperimentStateActive,
        Func<TResult> onShadowExperimentStateInactive,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ShadowExperimentStateActive => onShadowExperimentStateActive(),
            _ when this == ShadowExperimentStateInactive => onShadowExperimentStateInactive(),
            _ => otherwise(Value)
        };

    public void Match(Action onShadowExperimentStateActive,
        Action onShadowExperimentStateInactive,
        Action<string> otherwise)
    {
        if (this == ShadowExperimentStateActive) onShadowExperimentStateActive();
        else if (this == ShadowExperimentStateInactive) onShadowExperimentStateInactive();
        else otherwise(Value);
    }
}
