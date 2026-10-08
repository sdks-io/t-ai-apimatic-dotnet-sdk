using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Current lifecycle status of the video job.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VideoStatus>))]
public sealed record VideoStatus : OpenStringEnum<VideoStatus>
{
    private VideoStatus(string value) : base(value)
    {
    }

    public static readonly VideoStatus InProgress = new("in_progress");

    public static readonly VideoStatus Completed = new("completed");

    public static readonly VideoStatus Failed = new("failed");

    public TResult Match<TResult>(Func<TResult> onInProgress,
        Func<TResult> onCompleted,
        Func<TResult> onFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InProgress => onInProgress(),
            _ when this == Completed => onCompleted(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onInProgress, Action onCompleted, Action onFailed, Action<string> otherwise)
    {
        if (this == InProgress) onInProgress();
        else if (this == Completed) onCompleted();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
