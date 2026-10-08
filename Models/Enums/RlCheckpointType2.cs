using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Whether this is a training checkpoint or an inference checkpoint
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlCheckpointType2>))]
public sealed record RlCheckpointType2 : OpenStringEnum<RlCheckpointType2>
{
    private RlCheckpointType2(string value) : base(value)
    {
    }

    public static readonly RlCheckpointType2 CheckpointTypeTraining = new("CHECKPOINT_TYPE_TRAINING");

    public static readonly RlCheckpointType2 CheckpointTypeInference = new("CHECKPOINT_TYPE_INFERENCE");

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
