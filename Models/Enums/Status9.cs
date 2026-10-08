using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Job status after the cancel attempt. Only pending jobs can be
/// canceled. If the job is already running, done, or failed, the status
/// is returned unchanged.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status9>))]
public sealed record Status9 : OpenStringEnum<Status9>
{
    private Status9(string value) : base(value)
    {
    }

    public static readonly Status9 Canceled = new("canceled");

    public static readonly Status9 Running = new("running");

    public static readonly Status9 Done = new("done");

    public static readonly Status9 Failed = new("failed");

    public TResult Match<TResult>(Func<TResult> onCanceled,
        Func<TResult> onRunning,
        Func<TResult> onDone,
        Func<TResult> onFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Canceled => onCanceled(),
            _ when this == Running => onRunning(),
            _ when this == Done => onDone(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onCanceled, Action onRunning, Action onDone, Action onFailed, Action<string> otherwise)
    {
        if (this == Canceled) onCanceled();
        else if (this == Running) onRunning();
        else if (this == Done) onDone();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
