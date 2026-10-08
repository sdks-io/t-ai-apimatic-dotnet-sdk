using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Checkpoint variant to download: merged (full model) or adapter (LoRA weights only)
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlCheckpointVariant1>))]
public sealed record RlCheckpointVariant1 : OpenStringEnum<RlCheckpointVariant1>
{
    private RlCheckpointVariant1(string value) : base(value)
    {
    }

    public static readonly RlCheckpointVariant1 CheckpointVariantUnspecified = new("CHECKPOINT_VARIANT_UNSPECIFIED");

    public static readonly RlCheckpointVariant1 CheckpointVariantMerged = new("CHECKPOINT_VARIANT_MERGED");

    public static readonly RlCheckpointVariant1 CheckpointVariantAdapter = new("CHECKPOINT_VARIANT_ADAPTER");

    public TResult Match<TResult>(Func<TResult> onCheckpointVariantUnspecified,
        Func<TResult> onCheckpointVariantMerged,
        Func<TResult> onCheckpointVariantAdapter,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CheckpointVariantUnspecified => onCheckpointVariantUnspecified(),
            _ when this == CheckpointVariantMerged => onCheckpointVariantMerged(),
            _ when this == CheckpointVariantAdapter => onCheckpointVariantAdapter(),
            _ => otherwise(Value)
        };

    public void Match(Action onCheckpointVariantUnspecified,
        Action onCheckpointVariantMerged,
        Action onCheckpointVariantAdapter,
        Action<string> otherwise)
    {
        if (this == CheckpointVariantUnspecified) onCheckpointVariantUnspecified();
        else if (this == CheckpointVariantMerged) onCheckpointVariantMerged();
        else if (this == CheckpointVariantAdapter) onCheckpointVariantAdapter();
        else otherwise(Value);
    }
}
