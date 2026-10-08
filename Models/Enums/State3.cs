using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Output only. High-level rollout lifecycle state.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State3>))]
public sealed record State3 : OpenStringEnum<State3>
{
    private State3(string value) : base(value)
    {
    }

    public static readonly State3 RolloutStateRunning = new("ROLLOUT_STATE_RUNNING");

    public static readonly State3 RolloutStatePaused = new("ROLLOUT_STATE_PAUSED");

    public static readonly State3 RolloutStateStabilizing = new("ROLLOUT_STATE_STABILIZING");

    public static readonly State3 RolloutStateCompleted = new("ROLLOUT_STATE_COMPLETED");

    public static readonly State3 RolloutStatePending = new("ROLLOUT_STATE_PENDING");

    public static readonly State3 RolloutStateSystemPaused = new("ROLLOUT_STATE_SYSTEM_PAUSED");

    public static readonly State3 RolloutStateCancelling = new("ROLLOUT_STATE_CANCELLING");

    public static readonly State3 RolloutStateCanceled = new("ROLLOUT_STATE_CANCELED");

    public static readonly State3 RolloutStatePausing = new("ROLLOUT_STATE_PAUSING");

    public TResult Match<TResult>(Func<TResult> onRolloutStateRunning,
        Func<TResult> onRolloutStatePaused,
        Func<TResult> onRolloutStateStabilizing,
        Func<TResult> onRolloutStateCompleted,
        Func<TResult> onRolloutStatePending,
        Func<TResult> onRolloutStateSystemPaused,
        Func<TResult> onRolloutStateCancelling,
        Func<TResult> onRolloutStateCanceled,
        Func<TResult> onRolloutStatePausing,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RolloutStateRunning => onRolloutStateRunning(),
            _ when this == RolloutStatePaused => onRolloutStatePaused(),
            _ when this == RolloutStateStabilizing => onRolloutStateStabilizing(),
            _ when this == RolloutStateCompleted => onRolloutStateCompleted(),
            _ when this == RolloutStatePending => onRolloutStatePending(),
            _ when this == RolloutStateSystemPaused => onRolloutStateSystemPaused(),
            _ when this == RolloutStateCancelling => onRolloutStateCancelling(),
            _ when this == RolloutStateCanceled => onRolloutStateCanceled(),
            _ when this == RolloutStatePausing => onRolloutStatePausing(),
            _ => otherwise(Value)
        };

    public void Match(Action onRolloutStateRunning,
        Action onRolloutStatePaused,
        Action onRolloutStateStabilizing,
        Action onRolloutStateCompleted,
        Action onRolloutStatePending,
        Action onRolloutStateSystemPaused,
        Action onRolloutStateCancelling,
        Action onRolloutStateCanceled,
        Action onRolloutStatePausing,
        Action<string> otherwise)
    {
        if (this == RolloutStateRunning) onRolloutStateRunning();
        else if (this == RolloutStatePaused) onRolloutStatePaused();
        else if (this == RolloutStateStabilizing) onRolloutStateStabilizing();
        else if (this == RolloutStateCompleted) onRolloutStateCompleted();
        else if (this == RolloutStatePending) onRolloutStatePending();
        else if (this == RolloutStateSystemPaused) onRolloutStateSystemPaused();
        else if (this == RolloutStateCancelling) onRolloutStateCancelling();
        else if (this == RolloutStateCanceled) onRolloutStateCanceled();
        else if (this == RolloutStatePausing) onRolloutStatePausing();
        else otherwise(Value);
    }
}
