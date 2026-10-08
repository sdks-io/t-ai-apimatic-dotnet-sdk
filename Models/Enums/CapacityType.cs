using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Controls how replicas above reserved capacity behave. <c>stable</c> replicas stay running after scale-up; <c>preemptible</c> replicas may be evicted during capacity contention.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CapacityType>))]
public sealed record CapacityType : OpenStringEnum<CapacityType>
{
    private CapacityType(string value) : base(value)
    {
    }

    public static readonly CapacityType Stable = new("stable");

    public static readonly CapacityType Preemptible = new("preemptible");

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
