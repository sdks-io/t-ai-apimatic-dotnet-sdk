using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Canonical severity tier for the alert.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Severity>))]
public sealed record Severity : OpenStringEnum<Severity>
{
    private Severity(string value) : base(value)
    {
    }

    public static readonly Severity PhcSeverityInfo = new("PHC_SEVERITY_INFO");

    public static readonly Severity PhcSeverityWarning = new("PHC_SEVERITY_WARNING");

    public static readonly Severity PhcSeverityCritical = new("PHC_SEVERITY_CRITICAL");

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
