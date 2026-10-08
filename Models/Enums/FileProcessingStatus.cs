using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Lifecycle state of a file in the validation pipeline. The typical
/// progression is <c>PENDING</c> → <c>QUEUED</c> → <c>RUNNING</c> → <c>COMPLETED</c> /
/// <c>FAILED</c>. <c>INVALID_FORMAT</c> is a terminal state for files whose
/// contents failed validation in a user-correctable way.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FileProcessingStatus>))]
public sealed record FileProcessingStatus : OpenStringEnum<FileProcessingStatus>
{
    private FileProcessingStatus(string value) : base(value)
    {
    }

    public static readonly FileProcessingStatus Pending = new("PENDING");

    public static readonly FileProcessingStatus Queued = new("QUEUED");

    public static readonly FileProcessingStatus Running = new("RUNNING");

    public static readonly FileProcessingStatus Completed = new("COMPLETED");

    public static readonly FileProcessingStatus Failed = new("FAILED");

    public static readonly FileProcessingStatus InvalidFormat = new("INVALID_FORMAT");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onQueued,
        Func<TResult> onRunning,
        Func<TResult> onCompleted,
        Func<TResult> onFailed,
        Func<TResult> onInvalidFormat,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Queued => onQueued(),
            _ when this == Running => onRunning(),
            _ when this == Completed => onCompleted(),
            _ when this == Failed => onFailed(),
            _ when this == InvalidFormat => onInvalidFormat(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onQueued,
        Action onRunning,
        Action onCompleted,
        Action onFailed,
        Action onInvalidFormat,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Queued) onQueued();
        else if (this == Running) onRunning();
        else if (this == Completed) onCompleted();
        else if (this == Failed) onFailed();
        else if (this == InvalidFormat) onInvalidFormat();
        else otherwise(Value);
    }
}
