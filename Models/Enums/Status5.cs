using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The availability status of the hardware configuration
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status5>))]
public sealed record Status5 : OpenStringEnum<Status5>
{
    private Status5(string value) : base(value)
    {
    }

    public static readonly Status5 Available = new("available");

    public static readonly Status5 Unavailable = new("unavailable");

    public static readonly Status5 Insufficient = new("insufficient");

    public TResult Match<TResult>(Func<TResult> onAvailable,
        Func<TResult> onUnavailable,
        Func<TResult> onInsufficient,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Available => onAvailable(),
            _ when this == Unavailable => onUnavailable(),
            _ when this == Insufficient => onInsufficient(),
            _ => otherwise(Value)
        };

    public void Match(Action onAvailable, Action onUnavailable, Action onInsufficient, Action<string> otherwise)
    {
        if (this == Available) onAvailable();
        else if (this == Unavailable) onUnavailable();
        else if (this == Insufficient) onInsufficient();
        else otherwise(Value);
    }
}
