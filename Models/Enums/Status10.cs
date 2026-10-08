using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Current job status. Transitions: pending → running → done/failed. A pending job may also be canceled.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status10>))]
public sealed record Status10 : OpenStringEnum<Status10>
{
    private Status10(string value) : base(value)
    {
    }

    public static readonly Status10 Pending = new("pending");

    public static readonly Status10 Running = new("running");

    public static readonly Status10 Done = new("done");

    public static readonly Status10 Failed = new("failed");

    public static readonly Status10 Canceled = new("canceled");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onRunning,
        Func<TResult> onDone,
        Func<TResult> onFailed,
        Func<TResult> onCanceled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Running => onRunning(),
            _ when this == Done => onDone(),
            _ when this == Failed => onFailed(),
            _ when this == Canceled => onCanceled(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onRunning,
        Action onDone,
        Action onFailed,
        Action onCanceled,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Running) onRunning();
        else if (this == Done) onDone();
        else if (this == Failed) onFailed();
        else if (this == Canceled) onCanceled();
        else otherwise(Value);
    }
}
