using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Reason generation stopped.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RlStopReason>))]
public sealed record RlStopReason : OpenStringEnum<RlStopReason>
{
    private RlStopReason(string value) : base(value)
    {
    }

    public static readonly RlStopReason StopReasonLength = new("STOP_REASON_LENGTH");

    public static readonly RlStopReason StopReasonStop = new("STOP_REASON_STOP");

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
