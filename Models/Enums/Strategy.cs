using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Output only. Rollout strategy selected at creation.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Strategy>))]
public sealed record Strategy : OpenStringEnum<Strategy>
{
    private Strategy(string value) : base(value)
    {
    }

    public static readonly Strategy RolloutStrategyTypeRolling = new("ROLLOUT_STRATEGY_TYPE_ROLLING");

    public static readonly Strategy RolloutStrategyTypeCanary = new("ROLLOUT_STRATEGY_TYPE_CANARY");

    public static readonly Strategy RolloutStrategyTypeBlueGreen = new("ROLLOUT_STRATEGY_TYPE_BLUE_GREEN");

    public TResult Match<TResult>(Func<TResult> onRolloutStrategyTypeRolling,
        Func<TResult> onRolloutStrategyTypeCanary,
        Func<TResult> onRolloutStrategyTypeBlueGreen,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RolloutStrategyTypeRolling => onRolloutStrategyTypeRolling(),
            _ when this == RolloutStrategyTypeCanary => onRolloutStrategyTypeCanary(),
            _ when this == RolloutStrategyTypeBlueGreen => onRolloutStrategyTypeBlueGreen(),
            _ => otherwise(Value)
        };

    public void Match(Action onRolloutStrategyTypeRolling,
        Action onRolloutStrategyTypeCanary,
        Action onRolloutStrategyTypeBlueGreen,
        Action<string> otherwise)
    {
        if (this == RolloutStrategyTypeRolling) onRolloutStrategyTypeRolling();
        else if (this == RolloutStrategyTypeCanary) onRolloutStrategyTypeCanary();
        else if (this == RolloutStrategyTypeBlueGreen) onRolloutStrategyTypeBlueGreen();
        else otherwise(Value);
    }
}
