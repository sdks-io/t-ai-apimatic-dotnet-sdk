using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Whether the deployment serves client-visible responses or only mirrored shadow traffic.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TrafficMode>))]
public sealed record TrafficMode : OpenStringEnum<TrafficMode>
{
    private TrafficMode(string value) : base(value)
    {
    }

    public static readonly TrafficMode TrafficModeLive = new("TRAFFIC_MODE_LIVE");

    public static readonly TrafficMode TrafficModeShadow = new("TRAFFIC_MODE_SHADOW");

    public TResult Match<TResult>(Func<TResult> onTrafficModeLive,
        Func<TResult> onTrafficModeShadow,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TrafficModeLive => onTrafficModeLive(),
            _ when this == TrafficModeShadow => onTrafficModeShadow(),
            _ => otherwise(Value)
        };

    public void Match(Action onTrafficModeLive, Action onTrafficModeShadow, Action<string> otherwise)
    {
        if (this == TrafficModeLive) onTrafficModeLive();
        else if (this == TrafficModeShadow) onTrafficModeShadow();
        else otherwise(Value);
    }
}
