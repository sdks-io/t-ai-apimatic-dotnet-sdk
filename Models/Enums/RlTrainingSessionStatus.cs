using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Status of the training session
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlTrainingSessionStatus>))]
public sealed record RlTrainingSessionStatus : OpenStringEnum<RlTrainingSessionStatus>
{
    private RlTrainingSessionStatus(string value) : base(value)
    {
    }

    public static readonly RlTrainingSessionStatus TrainingSessionStatusUnspecified = new(
        "TRAINING_SESSION_STATUS_UNSPECIFIED");

    public static readonly RlTrainingSessionStatus TrainingSessionStatusCreating = new(
        "TRAINING_SESSION_STATUS_CREATING");

    public static readonly RlTrainingSessionStatus TrainingSessionStatusRunning = new(
        "TRAINING_SESSION_STATUS_RUNNING");

    public static readonly RlTrainingSessionStatus TrainingSessionStatusStopped = new(
        "TRAINING_SESSION_STATUS_STOPPED");

    public static readonly RlTrainingSessionStatus TrainingSessionStatusStopping = new(
        "TRAINING_SESSION_STATUS_STOPPING");

    public static readonly RlTrainingSessionStatus TrainingSessionStatusError = new("TRAINING_SESSION_STATUS_ERROR");

    public static readonly RlTrainingSessionStatus TrainingSessionStatusExpired = new(
        "TRAINING_SESSION_STATUS_EXPIRED");

    public TResult Match<TResult>(Func<TResult> onTrainingSessionStatusUnspecified,
        Func<TResult> onTrainingSessionStatusCreating,
        Func<TResult> onTrainingSessionStatusRunning,
        Func<TResult> onTrainingSessionStatusStopped,
        Func<TResult> onTrainingSessionStatusStopping,
        Func<TResult> onTrainingSessionStatusError,
        Func<TResult> onTrainingSessionStatusExpired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TrainingSessionStatusUnspecified => onTrainingSessionStatusUnspecified(),
            _ when this == TrainingSessionStatusCreating => onTrainingSessionStatusCreating(),
            _ when this == TrainingSessionStatusRunning => onTrainingSessionStatusRunning(),
            _ when this == TrainingSessionStatusStopped => onTrainingSessionStatusStopped(),
            _ when this == TrainingSessionStatusStopping => onTrainingSessionStatusStopping(),
            _ when this == TrainingSessionStatusError => onTrainingSessionStatusError(),
            _ when this == TrainingSessionStatusExpired => onTrainingSessionStatusExpired(),
            _ => otherwise(Value)
        };

    public void Match(Action onTrainingSessionStatusUnspecified,
        Action onTrainingSessionStatusCreating,
        Action onTrainingSessionStatusRunning,
        Action onTrainingSessionStatusStopped,
        Action onTrainingSessionStatusStopping,
        Action onTrainingSessionStatusError,
        Action onTrainingSessionStatusExpired,
        Action<string> otherwise)
    {
        if (this == TrainingSessionStatusUnspecified) onTrainingSessionStatusUnspecified();
        else if (this == TrainingSessionStatusCreating) onTrainingSessionStatusCreating();
        else if (this == TrainingSessionStatusRunning) onTrainingSessionStatusRunning();
        else if (this == TrainingSessionStatusStopped) onTrainingSessionStatusStopped();
        else if (this == TrainingSessionStatusStopping) onTrainingSessionStatusStopping();
        else if (this == TrainingSessionStatusError) onTrainingSessionStatusError();
        else if (this == TrainingSessionStatusExpired) onTrainingSessionStatusExpired();
        else otherwise(Value);
    }
}
