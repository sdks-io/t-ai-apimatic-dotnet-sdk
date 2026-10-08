using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Sort order for returned alerts. Omit for newest alerts first.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderBy>))]
public sealed record OrderBy : OpenStringEnum<OrderBy>
{
    private OrderBy(string value) : base(value)
    {
    }

    public static readonly OrderBy PhcAlertOrderStartedAtAsc = new("PHC_ALERT_ORDER_STARTED_AT_ASC");

    public static readonly OrderBy PhcAlertOrderStartedAtDesc = new("PHC_ALERT_ORDER_STARTED_AT_DESC");

    public TResult Match<TResult>(Func<TResult> onPhcAlertOrderStartedAtAsc,
        Func<TResult> onPhcAlertOrderStartedAtDesc,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PhcAlertOrderStartedAtAsc => onPhcAlertOrderStartedAtAsc(),
            _ when this == PhcAlertOrderStartedAtDesc => onPhcAlertOrderStartedAtDesc(),
            _ => otherwise(Value)
        };

    public void Match(Action onPhcAlertOrderStartedAtAsc, Action onPhcAlertOrderStartedAtDesc, Action<string> otherwise)
    {
        if (this == PhcAlertOrderStartedAtAsc) onPhcAlertOrderStartedAtAsc();
        else if (this == PhcAlertOrderStartedAtDesc) onPhcAlertOrderStartedAtDesc();
        else otherwise(Value);
    }
}
