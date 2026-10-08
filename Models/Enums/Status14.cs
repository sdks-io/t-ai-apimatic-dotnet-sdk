using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Lifecycle filter. Omit to return firing alerts.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status14>))]
public sealed record Status14 : OpenStringEnum<Status14>
{
    private Status14(string value) : base(value)
    {
    }

    public static readonly Status14 PhcAlertStatusFiring = new("PHC_ALERT_STATUS_FIRING");

    public static readonly Status14 PhcAlertStatusResolved = new("PHC_ALERT_STATUS_RESOLVED");

    public static readonly Status14 PhcAlertStatusAll = new("PHC_ALERT_STATUS_ALL");

    public TResult Match<TResult>(Func<TResult> onPhcAlertStatusFiring,
        Func<TResult> onPhcAlertStatusResolved,
        Func<TResult> onPhcAlertStatusAll,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PhcAlertStatusFiring => onPhcAlertStatusFiring(),
            _ when this == PhcAlertStatusResolved => onPhcAlertStatusResolved(),
            _ when this == PhcAlertStatusAll => onPhcAlertStatusAll(),
            _ => otherwise(Value)
        };

    public void Match(Action onPhcAlertStatusFiring,
        Action onPhcAlertStatusResolved,
        Action onPhcAlertStatusAll,
        Action<string> otherwise)
    {
        if (this == PhcAlertStatusFiring) onPhcAlertStatusFiring();
        else if (this == PhcAlertStatusResolved) onPhcAlertStatusResolved();
        else if (this == PhcAlertStatusAll) onPhcAlertStatusAll();
        else otherwise(Value);
    }
}
