using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The desired state of the endpoint
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State7>))]
public sealed record State7 : OpenStringEnum<State7>
{
    private State7(string value) : base(value)
    {
    }

    public static readonly State7 Started = new("STARTED");

    public static readonly State7 Stopped = new("STOPPED");

    public TResult Match<TResult>(Func<TResult> onStarted, Func<TResult> onStopped, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Started => onStarted(),
            _ when this == Stopped => onStopped(),
            _ => otherwise(Value)
        };

    public void Match(Action onStarted, Action onStopped, Action<string> otherwise)
    {
        if (this == Started) onStarted();
        else if (this == Stopped) onStopped();
        else otherwise(Value);
    }
}
