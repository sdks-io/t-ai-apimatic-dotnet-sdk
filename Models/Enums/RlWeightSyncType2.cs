using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// How updated parameters are made available for sampling. See <c>WeightSyncType</c> for accepted values.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlWeightSyncType2>))]
public sealed record RlWeightSyncType2 : OpenStringEnum<RlWeightSyncType2>
{
    private RlWeightSyncType2(string value) : base(value)
    {
    }

    public static readonly RlWeightSyncType2 WeightSyncTypeSynchronous = new("WEIGHT_SYNC_TYPE_SYNCHRONOUS");

    public static readonly RlWeightSyncType2 WeightSyncTypeBackgroundPublish = new(
        "WEIGHT_SYNC_TYPE_BACKGROUND_PUBLISH");

    public static readonly RlWeightSyncType2 WeightSyncTypePipeline = new("WEIGHT_SYNC_TYPE_PIPELINE");

    public TResult Match<TResult>(Func<TResult> onWeightSyncTypeSynchronous,
        Func<TResult> onWeightSyncTypeBackgroundPublish,
        Func<TResult> onWeightSyncTypePipeline,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == WeightSyncTypeSynchronous => onWeightSyncTypeSynchronous(),
            _ when this == WeightSyncTypeBackgroundPublish => onWeightSyncTypeBackgroundPublish(),
            _ when this == WeightSyncTypePipeline => onWeightSyncTypePipeline(),
            _ => otherwise(Value)
        };

    public void Match(Action onWeightSyncTypeSynchronous,
        Action onWeightSyncTypeBackgroundPublish,
        Action onWeightSyncTypePipeline,
        Action<string> otherwise)
    {
        if (this == WeightSyncTypeSynchronous) onWeightSyncTypeSynchronous();
        else if (this == WeightSyncTypeBackgroundPublish) onWeightSyncTypeBackgroundPublish();
        else if (this == WeightSyncTypePipeline) onWeightSyncTypePipeline();
        else otherwise(Value);
    }
}
