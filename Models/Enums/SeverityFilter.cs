using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SeverityFilter>))]
public sealed record SeverityFilter : OpenStringEnum<SeverityFilter>
{
    private SeverityFilter(string value) : base(value)
    {
    }

    public static readonly SeverityFilter PhcSeverityInfo = new("PHC_SEVERITY_INFO");

    public static readonly SeverityFilter PhcSeverityWarning = new("PHC_SEVERITY_WARNING");

    public static readonly SeverityFilter PhcSeverityCritical = new("PHC_SEVERITY_CRITICAL");

    public TResult Match<TResult>(Func<TResult> onPhcSeverityInfo,
        Func<TResult> onPhcSeverityWarning,
        Func<TResult> onPhcSeverityCritical,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PhcSeverityInfo => onPhcSeverityInfo(),
            _ when this == PhcSeverityWarning => onPhcSeverityWarning(),
            _ when this == PhcSeverityCritical => onPhcSeverityCritical(),
            _ => otherwise(Value)
        };

    public void Match(Action onPhcSeverityInfo,
        Action onPhcSeverityWarning,
        Action onPhcSeverityCritical,
        Action<string> otherwise)
    {
        if (this == PhcSeverityInfo) onPhcSeverityInfo();
        else if (this == PhcSeverityWarning) onPhcSeverityWarning();
        else if (this == PhcSeverityCritical) onPhcSeverityCritical();
        else otherwise(Value);
    }
}
