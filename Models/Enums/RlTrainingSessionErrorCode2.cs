using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Finite machine-readable reason code for UI branching
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlTrainingSessionErrorCode2>))]
public sealed record RlTrainingSessionErrorCode2 : OpenStringEnum<RlTrainingSessionErrorCode2>
{
    private RlTrainingSessionErrorCode2(string value) : base(value)
    {
    }

    public static readonly RlTrainingSessionErrorCode2 TrainingSessionErrorCodeResourceUnavailable = new(
        "TRAINING_SESSION_ERROR_CODE_RESOURCE_UNAVAILABLE");

    public static readonly RlTrainingSessionErrorCode2 TrainingSessionErrorCodeResourceAtCapacity = new(
        "TRAINING_SESSION_ERROR_CODE_RESOURCE_AT_CAPACITY");

    public static readonly RlTrainingSessionErrorCode2 TrainingSessionErrorCodeTimedOut = new(
        "TRAINING_SESSION_ERROR_CODE_TIMED_OUT");

    public static readonly RlTrainingSessionErrorCode2 TrainingSessionErrorCodeSessionFailed = new(
        "TRAINING_SESSION_ERROR_CODE_SESSION_FAILED");

    public TResult Match<TResult>(Func<TResult> onTrainingSessionErrorCodeResourceUnavailable,
        Func<TResult> onTrainingSessionErrorCodeResourceAtCapacity,
        Func<TResult> onTrainingSessionErrorCodeTimedOut,
        Func<TResult> onTrainingSessionErrorCodeSessionFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this ==
                TrainingSessionErrorCodeResourceUnavailable => onTrainingSessionErrorCodeResourceUnavailable(),
            _ when this == TrainingSessionErrorCodeResourceAtCapacity => onTrainingSessionErrorCodeResourceAtCapacity(),
            _ when this == TrainingSessionErrorCodeTimedOut => onTrainingSessionErrorCodeTimedOut(),
            _ when this == TrainingSessionErrorCodeSessionFailed => onTrainingSessionErrorCodeSessionFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onTrainingSessionErrorCodeResourceUnavailable,
        Action onTrainingSessionErrorCodeResourceAtCapacity,
        Action onTrainingSessionErrorCodeTimedOut,
        Action onTrainingSessionErrorCodeSessionFailed,
        Action<string> otherwise)
    {
        if (this == TrainingSessionErrorCodeResourceUnavailable) onTrainingSessionErrorCodeResourceUnavailable();
        else if (this == TrainingSessionErrorCodeResourceAtCapacity) onTrainingSessionErrorCodeResourceAtCapacity();
        else if (this == TrainingSessionErrorCodeTimedOut) onTrainingSessionErrorCodeTimedOut();
        else if (this == TrainingSessionErrorCodeSessionFailed) onTrainingSessionErrorCodeSessionFailed();
        else otherwise(Value);
    }
}
