using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Mode2>))]
public sealed record Mode2 : OpenStringEnum<Mode2>
{
    private Mode2(string value) : base(value)
    {
    }

    public static readonly Mode2 RemediationModeVmOnly = new("REMEDIATION_MODE_VM_ONLY");

    public static readonly Mode2 RemediationModeHostAware = new("REMEDIATION_MODE_HOST_AWARE");

    public static readonly Mode2 RemediationModeEvictWithoutReplacement = new(
        "REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT");

    public static readonly Mode2 RemediationModeRebootVm = new("REMEDIATION_MODE_REBOOT_VM");

    public static readonly Mode2 RemediationModeHostPowerCycle = new("REMEDIATION_MODE_HOST_POWER_CYCLE");

    public TResult Match<TResult>(Func<TResult> onRemediationModeVmOnly,
        Func<TResult> onRemediationModeHostAware,
        Func<TResult> onRemediationModeEvictWithoutReplacement,
        Func<TResult> onRemediationModeRebootVm,
        Func<TResult> onRemediationModeHostPowerCycle,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RemediationModeVmOnly => onRemediationModeVmOnly(),
            _ when this == RemediationModeHostAware => onRemediationModeHostAware(),
            _ when this == RemediationModeEvictWithoutReplacement => onRemediationModeEvictWithoutReplacement(),
            _ when this == RemediationModeRebootVm => onRemediationModeRebootVm(),
            _ when this == RemediationModeHostPowerCycle => onRemediationModeHostPowerCycle(),
            _ => otherwise(Value)
        };

    public void Match(Action onRemediationModeVmOnly,
        Action onRemediationModeHostAware,
        Action onRemediationModeEvictWithoutReplacement,
        Action onRemediationModeRebootVm,
        Action onRemediationModeHostPowerCycle,
        Action<string> otherwise)
    {
        if (this == RemediationModeVmOnly) onRemediationModeVmOnly();
        else if (this == RemediationModeHostAware) onRemediationModeHostAware();
        else if (this == RemediationModeEvictWithoutReplacement) onRemediationModeEvictWithoutReplacement();
        else if (this == RemediationModeRebootVm) onRemediationModeRebootVm();
        else if (this == RemediationModeHostPowerCycle) onRemediationModeHostPowerCycle();
        else otherwise(Value);
    }
}
