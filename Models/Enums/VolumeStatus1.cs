using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Status of this volume version.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VolumeStatus1>))]
public sealed record VolumeStatus1 : OpenStringEnum<VolumeStatus1>
{
    private VolumeStatus1(string value) : base(value)
    {
    }

    public static readonly VolumeStatus1 VolumeStatusReady = new("ready");

    public static readonly VolumeStatus1 VolumeStatusPending = new("pending");

    public static readonly VolumeStatus1 VolumeStatusSyncing = new("syncing");

    public static readonly VolumeStatus1 VolumeStatusFailed = new("failed");

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
