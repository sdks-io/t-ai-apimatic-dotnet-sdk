using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Reason for stopping generation
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlStopReason2>))]
public sealed record RlStopReason2 : OpenStringEnum<RlStopReason2>
{
    private RlStopReason2(string value) : base(value)
    {
    }

    public static readonly RlStopReason2 StopReasonLength = new("STOP_REASON_LENGTH");

    public static readonly RlStopReason2 StopReasonStop = new("STOP_REASON_STOP");

    public TResult Match<TResult>(Func<TResult> onStopReasonLength,
        Func<TResult> onStopReasonStop,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == StopReasonLength => onStopReasonLength(),
            _ when this == StopReasonStop => onStopReasonStop(),
            _ => otherwise(Value)
        };

    public void Match(Action onStopReasonLength, Action onStopReasonStop, Action<string> otherwise)
    {
        if (this == StopReasonLength) onStopReasonLength();
        else if (this == StopReasonStop) onStopReasonStop();
        else otherwise(Value);
    }
}
