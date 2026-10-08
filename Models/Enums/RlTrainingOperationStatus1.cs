using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Operation status
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlTrainingOperationStatus1>))]
public sealed record RlTrainingOperationStatus1 : OpenStringEnum<RlTrainingOperationStatus1>
{
    private RlTrainingOperationStatus1(string value) : base(value)
    {
    }

    public static readonly RlTrainingOperationStatus1 TrainingOperationStatusUnspecified = new(
        "TRAINING_OPERATION_STATUS_UNSPECIFIED");

    public static readonly RlTrainingOperationStatus1 TrainingOperationStatusPending = new(
        "TRAINING_OPERATION_STATUS_PENDING");

    public static readonly RlTrainingOperationStatus1 TrainingOperationStatusRunning = new(
        "TRAINING_OPERATION_STATUS_RUNNING");

    public static readonly RlTrainingOperationStatus1 TrainingOperationStatusCompleted = new(
        "TRAINING_OPERATION_STATUS_COMPLETED");

    public static readonly RlTrainingOperationStatus1 TrainingOperationStatusFailed = new(
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
