using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Current state of the endpoint
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State8>))]
public sealed record State8 : OpenStringEnum<State8>
{
    private State8(string value) : base(value)
    {
    }

    public static readonly State8 Pending = new("PENDING");

    public static readonly State8 Starting = new("STARTING");

    public static readonly State8 Started = new("STARTED");

    public static readonly State8 Stopping = new("STOPPING");

    public static readonly State8 Stopped = new("STOPPED");

    public static readonly State8 Error = new("ERROR");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onStarting,
        Func<TResult> onStarted,
        Func<TResult> onStopping,
        Func<TResult> onStopped,
        Func<TResult> onError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Starting => onStarting(),
            _ when this == Started => onStarted(),
            _ when this == Stopping => onStopping(),
            _ when this == Stopped => onStopped(),
            _ when this == Error => onError(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onStarting,
        Action onStarted,
        Action onStopping,
        Action onStopped,
        Action onError,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Starting) onStarting();
        else if (this == Started) onStarted();
        else if (this == Stopping) onStopping();
        else if (this == Stopped) onStopped();
        else if (this == Error) onError();
        else otherwise(Value);
    }
}
