using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Controls how the importance-sampling ratio is computed in GRPO loss. Defaults to token-level ratios, which is the standard GRPO behavior. Use sequence-level ratios to enable GSPO-style loss calculation instead.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlGrpoLossRatioType2>))]
public sealed record RlGrpoLossRatioType2 : OpenStringEnum<RlGrpoLossRatioType2>
{
    private RlGrpoLossRatioType2(string value) : base(value)
    {
    }

    public static readonly RlGrpoLossRatioType2 GrpoLossRatioTypeToken = new("GRPO_LOSS_RATIO_TYPE_TOKEN");

    public static readonly RlGrpoLossRatioType2 GrpoLossRatioTypeSequence = new("GRPO_LOSS_RATIO_TYPE_SEQUENCE");

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
