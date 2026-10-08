using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Capacity behavior for replicas above reserved capacity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CapacityType2>))]
public sealed record CapacityType2 : OpenStringEnum<CapacityType2>
{
    private CapacityType2(string value) : base(value)
    {
    }

    public static readonly CapacityType2 Stable = new("stable");

    public static readonly CapacityType2 Preemptible = new("preemptible");

    public TResult Match<TResult>(Func<TResult> onStable,
        Func<TResult> onPreemptible,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Stable => onStable(),
            _ when this == Preemptible => onPreemptible(),
            _ => otherwise(Value)
        };

    public void Match(Action onStable, Action onPreemptible, Action<string> otherwise)
    {
        if (this == Stable) onStable();
        else if (this == Preemptible) onPreemptible();
        else otherwise(Value);
    }
}
