using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Status4>))]
public sealed record Status4 : OpenStringEnum<Status4>
{
    private Status4(string value) : base(value)
    {
    }

    public static readonly Status4 Queued = new("Queued");

    public static readonly Status4 Running = new("Running");

    public static readonly Status4 Complete = new("Complete");

    public static readonly Status4 Failed = new("Failed");

    public TResult Match<TResult>(Func<TResult> onQueued,
        Func<TResult> onRunning,
        Func<TResult> onComplete,
        Func<TResult> onFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Queued => onQueued(),
            _ when this == Running => onRunning(),
            _ when this == Complete => onComplete(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onQueued, Action onRunning, Action onComplete, Action onFailed, Action<string> otherwise)
    {
        if (this == Queued) onQueued();
        else if (this == Running) onRunning();
        else if (this == Complete) onComplete();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
