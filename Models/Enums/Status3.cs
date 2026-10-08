using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Current status of the shared volume.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status3>))]
public sealed record Status3 : OpenStringEnum<Status3>
{
    private Status3(string value) : base(value)
    {
    }

    public static readonly Status3 Scheduled = new("scheduled");

    public static readonly Status3 Available = new("available");

    public static readonly Status3 Bound = new("bound");

    public static readonly Status3 Provisioning = new("provisioning");

    public static readonly Status3 Deleting = new("deleting");

    public static readonly Status3 Failed = new("failed");

    public static readonly Status3 AccessRevoked = new("access_revoked");

    public static readonly Status3 Unknown = new("unknown");

    public TResult Match<TResult>(Func<TResult> onScheduled,
        Func<TResult> onAvailable,
        Func<TResult> onBound,
        Func<TResult> onProvisioning,
        Func<TResult> onDeleting,
        Func<TResult> onFailed,
        Func<TResult> onAccessRevoked,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Scheduled => onScheduled(),
            _ when this == Available => onAvailable(),
            _ when this == Bound => onBound(),
            _ when this == Provisioning => onProvisioning(),
            _ when this == Deleting => onDeleting(),
            _ when this == Failed => onFailed(),
            _ when this == AccessRevoked => onAccessRevoked(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onScheduled,
        Action onAvailable,
        Action onBound,
        Action onProvisioning,
        Action onDeleting,
        Action onFailed,
        Action onAccessRevoked,
        Action onUnknown,
        Action<string> otherwise)
    {
        if (this == Scheduled) onScheduled();
        else if (this == Available) onAvailable();
        else if (this == Bound) onBound();
        else if (this == Provisioning) onProvisioning();
        else if (this == Deleting) onDeleting();
        else if (this == Failed) onFailed();
        else if (this == AccessRevoked) onAccessRevoked();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
