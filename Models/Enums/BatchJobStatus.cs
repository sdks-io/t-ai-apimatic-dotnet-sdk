using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Current status of the batch job
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BatchJobStatus>))]
public sealed record BatchJobStatus : OpenStringEnum<BatchJobStatus>
{
    private BatchJobStatus(string value) : base(value)
    {
    }

    public static readonly BatchJobStatus Validating = new("VALIDATING");

    public static readonly BatchJobStatus InProgress = new("IN_PROGRESS");

    public static readonly BatchJobStatus Completed = new("COMPLETED");

    public static readonly BatchJobStatus Failed = new("FAILED");

    public static readonly BatchJobStatus Expired = new("EXPIRED");

    public static readonly BatchJobStatus Cancelled = new("CANCELLED");

    public TResult Match<TResult>(Func<TResult> onValidating,
        Func<TResult> onInProgress,
        Func<TResult> onCompleted,
        Func<TResult> onFailed,
        Func<TResult> onExpired,
        Func<TResult> onCancelled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Validating => onValidating(),
            _ when this == InProgress => onInProgress(),
            _ when this == Completed => onCompleted(),
            _ when this == Failed => onFailed(),
            _ when this == Expired => onExpired(),
            _ when this == Cancelled => onCancelled(),
            _ => otherwise(Value)
        };

    public void Match(Action onValidating,
        Action onInProgress,
        Action onCompleted,
        Action onFailed,
        Action onExpired,
        Action onCancelled,
        Action<string> otherwise)
    {
        if (this == Validating) onValidating();
        else if (this == InProgress) onInProgress();
        else if (this == Completed) onCompleted();
        else if (this == Failed) onFailed();
        else if (this == Expired) onExpired();
        else if (this == Cancelled) onCancelled();
        else otherwise(Value);
    }
}
