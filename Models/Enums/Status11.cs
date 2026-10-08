using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The status of the evaluation job
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status11>))]
public sealed record Status11 : OpenStringEnum<Status11>
{
    private Status11(string value) : base(value)
    {
    }

    public static readonly Status11 Completed = new("completed");

    public static readonly Status11 Error = new("error");

    public static readonly Status11 UserError = new("user_error");

    public static readonly Status11 Running = new("running");

    public static readonly Status11 Queued = new("queued");

    public static readonly Status11 Pending = new("pending");

    public TResult Match<TResult>(Func<TResult> onCompleted,
        Func<TResult> onError,
        Func<TResult> onUserError,
        Func<TResult> onRunning,
        Func<TResult> onQueued,
        Func<TResult> onPending,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Completed => onCompleted(),
            _ when this == Error => onError(),
            _ when this == UserError => onUserError(),
            _ when this == Running => onRunning(),
            _ when this == Queued => onQueued(),
            _ when this == Pending => onPending(),
            _ => otherwise(Value)
        };

    public void Match(Action onCompleted,
        Action onError,
        Action onUserError,
        Action onRunning,
        Action onQueued,
        Action onPending,
        Action<string> otherwise)
    {
        if (this == Completed) onCompleted();
        else if (this == Error) onError();
        else if (this == UserError) onUserError();
        else if (this == Running) onRunning();
        else if (this == Queued) onQueued();
        else if (this == Pending) onPending();
        else otherwise(Value);
    }
}
