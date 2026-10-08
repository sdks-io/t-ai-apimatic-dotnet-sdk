using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Scaling strategy for the Muon optimizer.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlMuonScalingStrategy2>))]
public sealed record RlMuonScalingStrategy2 : OpenStringEnum<RlMuonScalingStrategy2>
{
    private RlMuonScalingStrategy2(string value) : base(value)
    {
    }

    public static readonly RlMuonScalingStrategy2 MuonScalingStrategyUnspecified = new(
        "MUON_SCALING_STRATEGY_UNSPECIFIED");

    public static readonly RlMuonScalingStrategy2 MuonScalingStrategyMatchAdam = new(
        "MUON_SCALING_STRATEGY_MATCH_ADAM");

    public static readonly RlMuonScalingStrategy2 MuonScalingStrategyOriginal = new("MUON_SCALING_STRATEGY_ORIGINAL");

    public TResult Match<TResult>(Func<TResult> onMuonScalingStrategyUnspecified,
        Func<TResult> onMuonScalingStrategyMatchAdam,
        Func<TResult> onMuonScalingStrategyOriginal,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MuonScalingStrategyUnspecified => onMuonScalingStrategyUnspecified(),
            _ when this == MuonScalingStrategyMatchAdam => onMuonScalingStrategyMatchAdam(),
            _ when this == MuonScalingStrategyOriginal => onMuonScalingStrategyOriginal(),
            _ => otherwise(Value)
        };

    public void Match(Action onMuonScalingStrategyUnspecified,
        Action onMuonScalingStrategyMatchAdam,
        Action onMuonScalingStrategyOriginal,
        Action<string> otherwise)
    {
        if (this == MuonScalingStrategyUnspecified) onMuonScalingStrategyUnspecified();
        else if (this == MuonScalingStrategyMatchAdam) onMuonScalingStrategyMatchAdam();
        else if (this == MuonScalingStrategyOriginal) onMuonScalingStrategyOriginal();
        else otherwise(Value);
    }
}
