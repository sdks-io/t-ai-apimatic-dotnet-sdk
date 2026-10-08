using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RlTrainingOperationStatus>))]
public sealed record RlTrainingOperationStatus : OpenStringEnum<RlTrainingOperationStatus>
{
    private RlTrainingOperationStatus(string value) : base(value)
    {
    }

    public static readonly RlTrainingOperationStatus TrainingOperationStatusUnspecified = new(
        "TRAINING_OPERATION_STATUS_UNSPECIFIED");

    public static readonly RlTrainingOperationStatus TrainingOperationStatusPending = new(
        "TRAINING_OPERATION_STATUS_PENDING");

    public static readonly RlTrainingOperationStatus TrainingOperationStatusRunning = new(
        "TRAINING_OPERATION_STATUS_RUNNING");

    public static readonly RlTrainingOperationStatus TrainingOperationStatusCompleted = new(
        "TRAINING_OPERATION_STATUS_COMPLETED");

    public static readonly RlTrainingOperationStatus TrainingOperationStatusFailed = new(
        "TRAINING_OPERATION_STATUS_FAILED");

    public TResult Match<TResult>(Func<TResult> onTrainingOperationStatusUnspecified,
        Func<TResult> onTrainingOperationStatusPending,
        Func<TResult> onTrainingOperationStatusRunning,
        Func<TResult> onTrainingOperationStatusCompleted,
        Func<TResult> onTrainingOperationStatusFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TrainingOperationStatusUnspecified => onTrainingOperationStatusUnspecified(),
            _ when this == TrainingOperationStatusPending => onTrainingOperationStatusPending(),
            _ when this == TrainingOperationStatusRunning => onTrainingOperationStatusRunning(),
            _ when this == TrainingOperationStatusCompleted => onTrainingOperationStatusCompleted(),
            _ when this == TrainingOperationStatusFailed => onTrainingOperationStatusFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onTrainingOperationStatusUnspecified,
        Action onTrainingOperationStatusPending,
        Action onTrainingOperationStatusRunning,
        Action onTrainingOperationStatusCompleted,
        Action onTrainingOperationStatusFailed,
        Action<string> otherwise)
    {
        if (this == TrainingOperationStatusUnspecified) onTrainingOperationStatusUnspecified();
        else if (this == TrainingOperationStatusPending) onTrainingOperationStatusPending();
        else if (this == TrainingOperationStatusRunning) onTrainingOperationStatusRunning();
        else if (this == TrainingOperationStatusCompleted) onTrainingOperationStatusCompleted();
        else if (this == TrainingOperationStatusFailed) onTrainingOperationStatusFailed();
        else otherwise(Value);
    }
}
