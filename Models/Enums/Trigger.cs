using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// RemediationTrigger specifies how the remediation was triggered.
/// <list type="bullet">
///   <item><description><c>REMEDIATION_TRIGGER_MANUAL</c>: A user-initiated remediation (either via web UI or API call).</description></item>
///   <item><description><c>REMEDIATION_TRIGGER_AUTOMATED</c>: A system-initiated remediation that requires approval.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Trigger>))]
public sealed record Trigger : OpenStringEnum<Trigger>
{
    private Trigger(string value) : base(value)
    {
    }

    public static readonly Trigger RemediationTriggerManual = new("REMEDIATION_TRIGGER_MANUAL");

    public static readonly Trigger RemediationTriggerAutomated = new("REMEDIATION_TRIGGER_AUTOMATED");

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
