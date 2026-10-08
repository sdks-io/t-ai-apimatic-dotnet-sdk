using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Time window size for rows. 'hour' returns ~24x more rows than 'day'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Granularity>))]
public sealed record Granularity : OpenStringEnum<Granularity>
{
    private Granularity(string value) : base(value)
    {
    }

    public static readonly Granularity Day = new("day");

    public static readonly Granularity Hour = new("hour");

    public TResult Match<TResult>(Func<TResult> onDay, Func<TResult> onHour, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Day => onDay(),
            _ when this == Hour => onHour(),
            _ => otherwise(Value)
        };

    public void Match(Action onDay, Action onHour, Action<string> otherwise)
    {
        if (this == Day) onDay();
        else if (this == Hour) onHour();
        else otherwise(Value);
    }
}
