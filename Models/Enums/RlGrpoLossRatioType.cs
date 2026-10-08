using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Controls whether GRPO loss uses token-level or sequence-level importance ratios.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlGrpoLossRatioType>))]
public sealed record RlGrpoLossRatioType : OpenStringEnum<RlGrpoLossRatioType>
{
    private RlGrpoLossRatioType(string value) : base(value)
    {
    }

    public static readonly RlGrpoLossRatioType GrpoLossRatioTypeToken = new("GRPO_LOSS_RATIO_TYPE_TOKEN");

    public static readonly RlGrpoLossRatioType GrpoLossRatioTypeSequence = new("GRPO_LOSS_RATIO_TYPE_SEQUENCE");

    public TResult Match<TResult>(Func<TResult> onGrpoLossRatioTypeToken,
        Func<TResult> onGrpoLossRatioTypeSequence,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == GrpoLossRatioTypeToken => onGrpoLossRatioTypeToken(),
            _ when this == GrpoLossRatioTypeSequence => onGrpoLossRatioTypeSequence(),
            _ => otherwise(Value)
        };

    public void Match(Action onGrpoLossRatioTypeToken, Action onGrpoLossRatioTypeSequence, Action<string> otherwise)
    {
        if (this == GrpoLossRatioTypeToken) onGrpoLossRatioTypeToken();
        else if (this == GrpoLossRatioTypeSequence) onGrpoLossRatioTypeSequence();
        else otherwise(Value);
    }
}
