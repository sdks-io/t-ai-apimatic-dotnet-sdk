using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Reason price estimation is unavailable for the requested fine-tune job.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UnavailableReason>))]
public sealed record UnavailableReason : OpenStringEnum<UnavailableReason>
{
    private UnavailableReason(string value) : base(value)
    {
    }

    public static readonly UnavailableReason MultimodalDataset = new("multimodal_dataset");

    public static readonly UnavailableReason TrainFileNotValidated = new("train_file_not_validated");

    public static readonly UnavailableReason EvalFileNotValidated = new("eval_file_not_validated");

    public static readonly UnavailableReason TrainFileInvalid = new("train_file_invalid");

    public static readonly UnavailableReason EvalFileInvalid = new("eval_file_invalid");

    public TResult Match<TResult>(Func<TResult> onMultimodalDataset,
        Func<TResult> onTrainFileNotValidated,
        Func<TResult> onEvalFileNotValidated,
        Func<TResult> onTrainFileInvalid,
        Func<TResult> onEvalFileInvalid,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MultimodalDataset => onMultimodalDataset(),
            _ when this == TrainFileNotValidated => onTrainFileNotValidated(),
            _ when this == EvalFileNotValidated => onEvalFileNotValidated(),
            _ when this == TrainFileInvalid => onTrainFileInvalid(),
            _ when this == EvalFileInvalid => onEvalFileInvalid(),
            _ => otherwise(Value)
        };

    public void Match(Action onMultimodalDataset,
        Action onTrainFileNotValidated,
        Action onEvalFileNotValidated,
        Action onTrainFileInvalid,
        Action onEvalFileInvalid,
        Action<string> otherwise)
    {
        if (this == MultimodalDataset) onMultimodalDataset();
        else if (this == TrainFileNotValidated) onTrainFileNotValidated();
        else if (this == EvalFileNotValidated) onEvalFileNotValidated();
        else if (this == TrainFileInvalid) onTrainFileInvalid();
        else if (this == EvalFileInvalid) onEvalFileInvalid();
        else otherwise(Value);
    }
}
