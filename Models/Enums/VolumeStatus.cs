using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Status of a volume version. Only ready versions can be mounted.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VolumeStatus>))]
public sealed record VolumeStatus : OpenStringEnum<VolumeStatus>
{
    private VolumeStatus(string value) : base(value)
    {
    }

    public static readonly VolumeStatus VolumeStatusReady = new("ready");

    public static readonly VolumeStatus VolumeStatusPending = new("pending");

    public static readonly VolumeStatus VolumeStatusSyncing = new("syncing");

    public static readonly VolumeStatus VolumeStatusFailed = new("failed");

    public TResult Match<TResult>(Func<TResult> onVolumeStatusReady,
        Func<TResult> onVolumeStatusPending,
        Func<TResult> onVolumeStatusSyncing,
        Func<TResult> onVolumeStatusFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == VolumeStatusReady => onVolumeStatusReady(),
            _ when this == VolumeStatusPending => onVolumeStatusPending(),
            _ when this == VolumeStatusSyncing => onVolumeStatusSyncing(),
            _ when this == VolumeStatusFailed => onVolumeStatusFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onVolumeStatusReady,
        Action onVolumeStatusPending,
        Action onVolumeStatusSyncing,
        Action onVolumeStatusFailed,
        Action<string> otherwise)
    {
        if (this == VolumeStatusReady) onVolumeStatusReady();
        else if (this == VolumeStatusPending) onVolumeStatusPending();
        else if (this == VolumeStatusSyncing) onVolumeStatusSyncing();
        else if (this == VolumeStatusFailed) onVolumeStatusFailed();
        else otherwise(Value);
    }
}
