using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Lifecycle state of the file validation pipeline. Files for
/// non-<c>fine-tune</c> purposes skip validation.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FileProcessingStatus2>))]
public sealed record FileProcessingStatus2 : OpenStringEnum<FileProcessingStatus2>
{
    private FileProcessingStatus2(string value) : base(value)
    {
    }

    public static readonly FileProcessingStatus2 Pending = new("PENDING");

    public static readonly FileProcessingStatus2 Queued = new("QUEUED");

    public static readonly FileProcessingStatus2 Running = new("RUNNING");

    public static readonly FileProcessingStatus2 Completed = new("COMPLETED");

    public static readonly FileProcessingStatus2 Failed = new("FAILED");

    public static readonly FileProcessingStatus2 InvalidFormat = new("INVALID_FORMAT");

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
