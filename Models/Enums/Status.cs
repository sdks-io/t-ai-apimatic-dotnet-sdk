using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Current lifecycle state of the asynchronous import job.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status>))]
public sealed record Status : OpenStringEnum<Status>
{
    private Status(string value) : base(value)
    {
    }

    public static readonly Status RemoteUploadStatusPending = new("REMOTE_UPLOAD_STATUS_PENDING");

    public static readonly Status RemoteUploadStatusRunning = new("REMOTE_UPLOAD_STATUS_RUNNING");

    public static readonly Status RemoteUploadStatusError = new("REMOTE_UPLOAD_STATUS_ERROR");

    public static readonly Status RemoteUploadStatusSucceeded = new("REMOTE_UPLOAD_STATUS_SUCCEEDED");

    public static readonly Status RemoteUploadStatusFailed = new("REMOTE_UPLOAD_STATUS_FAILED");

    public TResult Match<TResult>(Func<TResult> onRemoteUploadStatusPending,
        Func<TResult> onRemoteUploadStatusRunning,
        Func<TResult> onRemoteUploadStatusError,
        Func<TResult> onRemoteUploadStatusSucceeded,
        Func<TResult> onRemoteUploadStatusFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RemoteUploadStatusPending => onRemoteUploadStatusPending(),
            _ when this == RemoteUploadStatusRunning => onRemoteUploadStatusRunning(),
            _ when this == RemoteUploadStatusError => onRemoteUploadStatusError(),
            _ when this == RemoteUploadStatusSucceeded => onRemoteUploadStatusSucceeded(),
            _ when this == RemoteUploadStatusFailed => onRemoteUploadStatusFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onRemoteUploadStatusPending,
        Action onRemoteUploadStatusRunning,
        Action onRemoteUploadStatusError,
        Action onRemoteUploadStatusSucceeded,
        Action onRemoteUploadStatusFailed,
        Action<string> otherwise)
    {
        if (this == RemoteUploadStatusPending) onRemoteUploadStatusPending();
        else if (this == RemoteUploadStatusRunning) onRemoteUploadStatusRunning();
        else if (this == RemoteUploadStatusError) onRemoteUploadStatusError();
        else if (this == RemoteUploadStatusSucceeded) onRemoteUploadStatusSucceeded();
        else if (this == RemoteUploadStatusFailed) onRemoteUploadStatusFailed();
        else otherwise(Value);
    }
}
