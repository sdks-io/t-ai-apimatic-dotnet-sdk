using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RlGrpoLossAggregationType>))]
public sealed record RlGrpoLossAggregationType : OpenStringEnum<RlGrpoLossAggregationType>
{
    private RlGrpoLossAggregationType(string value) : base(value)
    {
    }

    public static readonly RlGrpoLossAggregationType GrpoLossAggregationTypeUnspecified = new(
        "GRPO_LOSS_AGGREGATION_TYPE_UNSPECIFIED");

    public static readonly RlGrpoLossAggregationType GrpoLossAggregationTypeFixedHorizon = new(
        "GRPO_LOSS_AGGREGATION_TYPE_FIXED_HORIZON");

    public static readonly RlGrpoLossAggregationType GrpoLossAggregationTypeTokenMean = new(
        "GRPO_LOSS_AGGREGATION_TYPE_TOKEN_MEAN");

    public static readonly RlGrpoLossAggregationType GrpoLossAggregationTypeSequenceMean = new(
        "GRPO_LOSS_AGGREGATION_TYPE_SEQUENCE_MEAN");

    public TResult Match<TResult>(Func<TResult> onGrpoLossAggregationTypeUnspecified,
        Func<TResult> onGrpoLossAggregationTypeFixedHorizon,
        Func<TResult> onGrpoLossAggregationTypeTokenMean,
        Func<TResult> onGrpoLossAggregationTypeSequenceMean,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == GrpoLossAggregationTypeUnspecified => onGrpoLossAggregationTypeUnspecified(),
            _ when this == GrpoLossAggregationTypeFixedHorizon => onGrpoLossAggregationTypeFixedHorizon(),
            _ when this == GrpoLossAggregationTypeTokenMean => onGrpoLossAggregationTypeTokenMean(),
            _ when this == GrpoLossAggregationTypeSequenceMean => onGrpoLossAggregationTypeSequenceMean(),
            _ => otherwise(Value)
        };

    public void Match(Action onGrpoLossAggregationTypeUnspecified,
        Action onGrpoLossAggregationTypeFixedHorizon,
        Action onGrpoLossAggregationTypeTokenMean,
        Action onGrpoLossAggregationTypeSequenceMean,
        Action<string> otherwise)
    {
        if (this == GrpoLossAggregationTypeUnspecified) onGrpoLossAggregationTypeUnspecified();
        else if (this == GrpoLossAggregationTypeFixedHorizon) onGrpoLossAggregationTypeFixedHorizon();
        else if (this == GrpoLossAggregationTypeTokenMean) onGrpoLossAggregationTypeTokenMean();
        else if (this == GrpoLossAggregationTypeSequenceMean) onGrpoLossAggregationTypeSequenceMean();
        else otherwise(Value);
    }
}
