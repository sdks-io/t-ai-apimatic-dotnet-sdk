using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Whether a checkpoint is saved for training resume or inference download.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlCheckpointType>))]
public sealed record RlCheckpointType : OpenStringEnum<RlCheckpointType>
{
    private RlCheckpointType(string value) : base(value)
    {
    }

    public static readonly RlCheckpointType CheckpointTypeTraining = new("CHECKPOINT_TYPE_TRAINING");

    public static readonly RlCheckpointType CheckpointTypeInference = new("CHECKPOINT_TYPE_INFERENCE");

    public TResult Match<TResult>(Func<TResult> onCheckpointTypeTraining,
        Func<TResult> onCheckpointTypeInference,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CheckpointTypeTraining => onCheckpointTypeTraining(),
            _ when this == CheckpointTypeInference => onCheckpointTypeInference(),
            _ => otherwise(Value)
        };

    public void Match(Action onCheckpointTypeTraining, Action onCheckpointTypeInference, Action<string> otherwise)
    {
        if (this == CheckpointTypeTraining) onCheckpointTypeTraining();
        else if (this == CheckpointTypeInference) onCheckpointTypeInference();
        else otherwise(Value);
    }
}
