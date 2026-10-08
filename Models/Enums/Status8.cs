using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Current status of the job
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status8>))]
public sealed record Status8 : OpenStringEnum<Status8>
{
    private Status8(string value) : base(value)
    {
    }

    public static readonly Status8 Pending = new("pending");

    public static readonly Status8 Queued = new("queued");

    public static readonly Status8 Running = new("running");

    public static readonly Status8 Completed = new("completed");

    public static readonly Status8 Error = new("error");

    public static readonly Status8 UserError = new("user_error");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onQueued,
        Func<TResult> onRunning,
        Func<TResult> onCompleted,
        Func<TResult> onError,
        Func<TResult> onUserError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Queued => onQueued(),
            _ when this == Running => onRunning(),
            _ when this == Completed => onCompleted(),
            _ when this == Error => onError(),
            _ when this == UserError => onUserError(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onQueued,
        Action onRunning,
        Action onCompleted,
        Action onError,
        Action onUserError,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Queued) onQueued();
        else if (this == Running) onRunning();
        else if (this == Completed) onCompleted();
        else if (this == Error) onError();
        else if (this == UserError) onUserError();
        else otherwise(Value);
    }
}
