using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Trigger1>))]
public sealed record Trigger1 : OpenStringEnum<Trigger1>
{
    private Trigger1(string value) : base(value)
    {
    }

    public static readonly Trigger1 RemediationTriggerManual = new("REMEDIATION_TRIGGER_MANUAL");

    public static readonly Trigger1 RemediationTriggerAutomated = new("REMEDIATION_TRIGGER_AUTOMATED");

    public TResult Match<TResult>(Func<TResult> onRemediationTriggerManual,
        Func<TResult> onRemediationTriggerAutomated,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RemediationTriggerManual => onRemediationTriggerManual(),
            _ when this == RemediationTriggerAutomated => onRemediationTriggerAutomated(),
            _ => otherwise(Value)
        };

    public void Match(Action onRemediationTriggerManual, Action onRemediationTriggerAutomated, Action<string> otherwise)
    {
        if (this == RemediationTriggerManual) onRemediationTriggerManual();
        else if (this == RemediationTriggerAutomated) onRemediationTriggerAutomated();
        else otherwise(Value);
    }
}
