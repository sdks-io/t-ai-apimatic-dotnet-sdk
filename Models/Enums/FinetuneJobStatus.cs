using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FinetuneJobStatus>))]
public sealed record FinetuneJobStatus : OpenStringEnum<FinetuneJobStatus>
{
    private FinetuneJobStatus(string value) : base(value)
    {
    }

    public static readonly FinetuneJobStatus Pending = new("pending");

    public static readonly FinetuneJobStatus Queued = new("queued");

    public static readonly FinetuneJobStatus Running = new("running");

    public static readonly FinetuneJobStatus Compressing = new("compressing");

    public static readonly FinetuneJobStatus Uploading = new("uploading");

    public static readonly FinetuneJobStatus CancelRequested = new("cancel_requested");

    public static readonly FinetuneJobStatus Cancelled = new("cancelled");

    public static readonly FinetuneJobStatus Error = new("error");

    public static readonly FinetuneJobStatus Completed = new("completed");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onQueued,
        Func<TResult> onRunning,
        Func<TResult> onCompressing,
        Func<TResult> onUploading,
        Func<TResult> onCancelRequested,
        Func<TResult> onCancelled,
        Func<TResult> onError,
        Func<TResult> onCompleted,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Queued => onQueued(),
            _ when this == Running => onRunning(),
            _ when this == Compressing => onCompressing(),
            _ when this == Uploading => onUploading(),
            _ when this == CancelRequested => onCancelRequested(),
            _ when this == Cancelled => onCancelled(),
            _ when this == Error => onError(),
            _ when this == Completed => onCompleted(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onQueued,
        Action onRunning,
        Action onCompressing,
        Action onUploading,
        Action onCancelRequested,
        Action onCancelled,
        Action onError,
        Action onCompleted,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Queued) onQueued();
        else if (this == Running) onRunning();
        else if (this == Compressing) onCompressing();
        else if (this == Uploading) onUploading();
        else if (this == CancelRequested) onCancelRequested();
        else if (this == Cancelled) onCancelled();
        else if (this == Error) onError();
        else if (this == Completed) onCompleted();
        else otherwise(Value);
    }
}
