using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Type of loss function to use
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlLossType2>))]
public sealed record RlLossType2 : OpenStringEnum<RlLossType2>
{
    private RlLossType2(string value) : base(value)
    {
    }

    public static readonly RlLossType2 LossTypeUnspecified = new("LOSS_TYPE_UNSPECIFIED");

    public static readonly RlLossType2 LossTypeCrossEntropy = new("LOSS_TYPE_CROSS_ENTROPY");

    public static readonly RlLossType2 LossTypeGrpo = new("LOSS_TYPE_GRPO");

    public static readonly RlLossType2 LossTypeImportanceSampling = new("LOSS_TYPE_IMPORTANCE_SAMPLING");

    public static readonly RlLossType2 LossTypePpo = new("LOSS_TYPE_PPO");

    public static readonly RlLossType2 LossTypeCispo = new("LOSS_TYPE_CISPO");

    public static readonly RlLossType2 LossTypeDro = new("LOSS_TYPE_DRO");

    public static readonly RlLossType2 LossTypeDppo = new("LOSS_TYPE_DPPO");

    public TResult Match<TResult>(Func<TResult> onLossTypeUnspecified,
        Func<TResult> onLossTypeCrossEntropy,
        Func<TResult> onLossTypeGrpo,
        Func<TResult> onLossTypeImportanceSampling,
        Func<TResult> onLossTypePpo,
        Func<TResult> onLossTypeCispo,
        Func<TResult> onLossTypeDro,
        Func<TResult> onLossTypeDppo,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LossTypeUnspecified => onLossTypeUnspecified(),
            _ when this == LossTypeCrossEntropy => onLossTypeCrossEntropy(),
            _ when this == LossTypeGrpo => onLossTypeGrpo(),
            _ when this == LossTypeImportanceSampling => onLossTypeImportanceSampling(),
            _ when this == LossTypePpo => onLossTypePpo(),
            _ when this == LossTypeCispo => onLossTypeCispo(),
            _ when this == LossTypeDro => onLossTypeDro(),
            _ when this == LossTypeDppo => onLossTypeDppo(),
            _ => otherwise(Value)
        };

    public void Match(Action onLossTypeUnspecified,
        Action onLossTypeCrossEntropy,
        Action onLossTypeGrpo,
        Action onLossTypeImportanceSampling,
        Action onLossTypePpo,
        Action onLossTypeCispo,
        Action onLossTypeDro,
        Action onLossTypeDppo,
        Action<string> otherwise)
    {
        if (this == LossTypeUnspecified) onLossTypeUnspecified();
        else if (this == LossTypeCrossEntropy) onLossTypeCrossEntropy();
        else if (this == LossTypeGrpo) onLossTypeGrpo();
        else if (this == LossTypeImportanceSampling) onLossTypeImportanceSampling();
        else if (this == LossTypePpo) onLossTypePpo();
        else if (this == LossTypeCispo) onLossTypeCispo();
        else if (this == LossTypeDro) onLossTypeDro();
        else if (this == LossTypeDppo) onLossTypeDppo();
        else otherwise(Value);
    }
}
