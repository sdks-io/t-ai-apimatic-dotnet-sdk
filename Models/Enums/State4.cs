using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Outcome of this step. Finished steps are PASSED, the live step mirrors the rollout state, skipped-over steps are SKIPPED, and unreached steps are PENDING.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State4>))]
public sealed record State4 : OpenStringEnum<State4>
{
    private State4(string value) : base(value)
    {
    }

    public static readonly State4 RolloutStepStatePending = new("ROLLOUT_STEP_STATE_PENDING");

    public static readonly State4 RolloutStepStateRunning = new("ROLLOUT_STEP_STATE_RUNNING");

    public static readonly State4 RolloutStepStatePassed = new("ROLLOUT_STEP_STATE_PASSED");

    public static readonly State4 RolloutStepStateFailed = new("ROLLOUT_STEP_STATE_FAILED");

    public static readonly State4 RolloutStepStatePaused = new("ROLLOUT_STEP_STATE_PAUSED");

    public static readonly State4 RolloutStepStateCanceled = new("ROLLOUT_STEP_STATE_CANCELED");

    public static readonly State4 RolloutStepStateSkipped = new("ROLLOUT_STEP_STATE_SKIPPED");

    public TResult Match<TResult>(Func<TResult> onRolloutStepStatePending,
        Func<TResult> onRolloutStepStateRunning,
        Func<TResult> onRolloutStepStatePassed,
        Func<TResult> onRolloutStepStateFailed,
        Func<TResult> onRolloutStepStatePaused,
        Func<TResult> onRolloutStepStateCanceled,
        Func<TResult> onRolloutStepStateSkipped,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RolloutStepStatePending => onRolloutStepStatePending(),
            _ when this == RolloutStepStateRunning => onRolloutStepStateRunning(),
            _ when this == RolloutStepStatePassed => onRolloutStepStatePassed(),
            _ when this == RolloutStepStateFailed => onRolloutStepStateFailed(),
            _ when this == RolloutStepStatePaused => onRolloutStepStatePaused(),
            _ when this == RolloutStepStateCanceled => onRolloutStepStateCanceled(),
            _ when this == RolloutStepStateSkipped => onRolloutStepStateSkipped(),
            _ => otherwise(Value)
        };

    public void Match(Action onRolloutStepStatePending,
        Action onRolloutStepStateRunning,
        Action onRolloutStepStatePassed,
        Action onRolloutStepStateFailed,
        Action onRolloutStepStatePaused,
        Action onRolloutStepStateCanceled,
        Action onRolloutStepStateSkipped,
        Action<string> otherwise)
    {
        if (this == RolloutStepStatePending) onRolloutStepStatePending();
        else if (this == RolloutStepStateRunning) onRolloutStepStateRunning();
        else if (this == RolloutStepStatePassed) onRolloutStepStatePassed();
        else if (this == RolloutStepStateFailed) onRolloutStepStateFailed();
        else if (this == RolloutStepStatePaused) onRolloutStepStatePaused();
        else if (this == RolloutStepStateCanceled) onRolloutStepStateCanceled();
        else if (this == RolloutStepStateSkipped) onRolloutStepStateSkipped();
        else otherwise(Value);
    }
}
