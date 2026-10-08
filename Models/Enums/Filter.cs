using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Narrow results to active or terminal rollouts. Omit to list all rollouts.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Filter>))]
public sealed record Filter : OpenStringEnum<Filter>
{
    private Filter(string value) : base(value)
    {
    }

    public static readonly Filter RolloutFilterActive = new("ROLLOUT_FILTER_ACTIVE");

    public static readonly Filter RolloutFilterTerminal = new("ROLLOUT_FILTER_TERMINAL");

    public TResult Match<TResult>(Func<TResult> onRolloutFilterActive,
        Func<TResult> onRolloutFilterTerminal,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RolloutFilterActive => onRolloutFilterActive(),
            _ when this == RolloutFilterTerminal => onRolloutFilterTerminal(),
            _ => otherwise(Value)
        };

    public void Match(Action onRolloutFilterActive, Action onRolloutFilterTerminal, Action<string> otherwise)
    {
        if (this == RolloutFilterActive) onRolloutFilterActive();
        else if (this == RolloutFilterTerminal) onRolloutFilterTerminal();
        else otherwise(Value);
    }
}
