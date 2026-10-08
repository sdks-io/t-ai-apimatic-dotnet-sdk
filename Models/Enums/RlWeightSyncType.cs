using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// How updated policy parameters are made available for sampling. SYNCHRONOUS waits for the policy update before returning; BACKGROUND_PUBLISH returns after scheduling the update; PIPELINE overlaps the update with in-flight sampling when possible.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlWeightSyncType>))]
public sealed record RlWeightSyncType : OpenStringEnum<RlWeightSyncType>
{
    private RlWeightSyncType(string value) : base(value)
    {
    }

    public static readonly RlWeightSyncType WeightSyncTypeSynchronous = new("WEIGHT_SYNC_TYPE_SYNCHRONOUS");

    public static readonly RlWeightSyncType WeightSyncTypeBackgroundPublish = new(
        "WEIGHT_SYNC_TYPE_BACKGROUND_PUBLISH");

    public static readonly RlWeightSyncType WeightSyncTypePipeline = new("WEIGHT_SYNC_TYPE_PIPELINE");

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
