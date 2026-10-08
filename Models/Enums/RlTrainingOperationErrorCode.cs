using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Application error code for a failed training operation
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlTrainingOperationErrorCode>))]
public sealed record RlTrainingOperationErrorCode : OpenStringEnum<RlTrainingOperationErrorCode>
{
    private RlTrainingOperationErrorCode(string value) : base(value)
    {
    }

    public static readonly RlTrainingOperationErrorCode TrainingOperationErrorCodeUnspecified = new(
        "TRAINING_OPERATION_ERROR_CODE_UNSPECIFIED");

    public static readonly RlTrainingOperationErrorCode TrainingOperationErrorCodeResourceExhausted = new(
        "TRAINING_OPERATION_ERROR_CODE_RESOURCE_EXHAUSTED");

    public static readonly RlTrainingOperationErrorCode TrainingOperationErrorCodeTimeout = new(
        "TRAINING_OPERATION_ERROR_CODE_TIMEOUT");

    public static readonly RlTrainingOperationErrorCode TrainingOperationErrorCodeInternalError = new(
        "TRAINING_OPERATION_ERROR_CODE_INTERNAL_ERROR");

    public static readonly RlTrainingOperationErrorCode TrainingOperationErrorCodeSessionNotActive = new(
        "TRAINING_OPERATION_ERROR_CODE_SESSION_NOT_ACTIVE");

    public static readonly RlTrainingOperationErrorCode TrainingOperationErrorCodeInvalidInput = new(
        "TRAINING_OPERATION_ERROR_CODE_INVALID_INPUT");

    public static readonly RlTrainingOperationErrorCode TrainingOperationErrorCodeNonFiniteLoss = new(
        "TRAINING_OPERATION_ERROR_CODE_NON_FINITE_LOSS");

    public TResult Match<TResult>(Func<TResult> onTrainingOperationErrorCodeUnspecified,
        Func<TResult> onTrainingOperationErrorCodeResourceExhausted,
        Func<TResult> onTrainingOperationErrorCodeTimeout,
        Func<TResult> onTrainingOperationErrorCodeInternalError,
        Func<TResult> onTrainingOperationErrorCodeSessionNotActive,
        Func<TResult> onTrainingOperationErrorCodeInvalidInput,
        Func<TResult> onTrainingOperationErrorCodeNonFiniteLoss,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TrainingOperationErrorCodeUnspecified => onTrainingOperationErrorCodeUnspecified(),
            _ when this ==
                TrainingOperationErrorCodeResourceExhausted => onTrainingOperationErrorCodeResourceExhausted(),
            _ when this == TrainingOperationErrorCodeTimeout => onTrainingOperationErrorCodeTimeout(),
            _ when this == TrainingOperationErrorCodeInternalError => onTrainingOperationErrorCodeInternalError(),
            _ when this == TrainingOperationErrorCodeSessionNotActive => onTrainingOperationErrorCodeSessionNotActive(),
            _ when this == TrainingOperationErrorCodeInvalidInput => onTrainingOperationErrorCodeInvalidInput(),
            _ when this == TrainingOperationErrorCodeNonFiniteLoss => onTrainingOperationErrorCodeNonFiniteLoss(),
            _ => otherwise(Value)
        };

    public void Match(Action onTrainingOperationErrorCodeUnspecified,
        Action onTrainingOperationErrorCodeResourceExhausted,
        Action onTrainingOperationErrorCodeTimeout,
        Action onTrainingOperationErrorCodeInternalError,
        Action onTrainingOperationErrorCodeSessionNotActive,
        Action onTrainingOperationErrorCodeInvalidInput,
        Action onTrainingOperationErrorCodeNonFiniteLoss,
        Action<string> otherwise)
    {
        if (this == TrainingOperationErrorCodeUnspecified) onTrainingOperationErrorCodeUnspecified();
        else if (this == TrainingOperationErrorCodeResourceExhausted) onTrainingOperationErrorCodeResourceExhausted();
        else if (this == TrainingOperationErrorCodeTimeout) onTrainingOperationErrorCodeTimeout();
        else if (this == TrainingOperationErrorCodeInternalError) onTrainingOperationErrorCodeInternalError();
        else if (this == TrainingOperationErrorCodeSessionNotActive) onTrainingOperationErrorCodeSessionNotActive();
        else if (this == TrainingOperationErrorCodeInvalidInput) onTrainingOperationErrorCodeInvalidInput();
        else if (this == TrainingOperationErrorCodeNonFiniteLoss) onTrainingOperationErrorCodeNonFiniteLoss();
        else otherwise(Value);
    }
}
