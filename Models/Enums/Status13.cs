using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Status13>))]
public sealed record Status13 : OpenStringEnum<Status13>
{
    private Status13(string value) : base(value)
    {
    }

    public static readonly Status13 TrainingSessionStatusCreating = new("TRAINING_SESSION_STATUS_CREATING");

    public static readonly Status13 TrainingSessionStatusRunning = new("TRAINING_SESSION_STATUS_RUNNING");

    public static readonly Status13 TrainingSessionStatusStopped = new("TRAINING_SESSION_STATUS_STOPPED");

    public static readonly Status13 TrainingSessionStatusStopping = new("TRAINING_SESSION_STATUS_STOPPING");

    public static readonly Status13 TrainingSessionStatusError = new("TRAINING_SESSION_STATUS_ERROR");

    public static readonly Status13 TrainingSessionStatusExpired = new("TRAINING_SESSION_STATUS_EXPIRED");

    public TResult Match<TResult>(Func<TResult> onTrainingSessionStatusCreating,
        Func<TResult> onTrainingSessionStatusRunning,
        Func<TResult> onTrainingSessionStatusStopped,
        Func<TResult> onTrainingSessionStatusStopping,
        Func<TResult> onTrainingSessionStatusError,
        Func<TResult> onTrainingSessionStatusExpired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TrainingSessionStatusCreating => onTrainingSessionStatusCreating(),
            _ when this == TrainingSessionStatusRunning => onTrainingSessionStatusRunning(),
            _ when this == TrainingSessionStatusStopped => onTrainingSessionStatusStopped(),
            _ when this == TrainingSessionStatusStopping => onTrainingSessionStatusStopping(),
            _ when this == TrainingSessionStatusError => onTrainingSessionStatusError(),
            _ when this == TrainingSessionStatusExpired => onTrainingSessionStatusExpired(),
            _ => otherwise(Value)
        };

    public void Match(Action onTrainingSessionStatusCreating,
        Action onTrainingSessionStatusRunning,
        Action onTrainingSessionStatusStopped,
        Action onTrainingSessionStatusStopping,
        Action onTrainingSessionStatusError,
        Action onTrainingSessionStatusExpired,
        Action<string> otherwise)
    {
        if (this == TrainingSessionStatusCreating) onTrainingSessionStatusCreating();
        else if (this == TrainingSessionStatusRunning) onTrainingSessionStatusRunning();
        else if (this == TrainingSessionStatusStopped) onTrainingSessionStatusStopped();
        else if (this == TrainingSessionStatusStopping) onTrainingSessionStatusStopping();
        else if (this == TrainingSessionStatusError) onTrainingSessionStatusError();
        else if (this == TrainingSessionStatusExpired) onTrainingSessionStatusExpired();
        else otherwise(Value);
    }
}
