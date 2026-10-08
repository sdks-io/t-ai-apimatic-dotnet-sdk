using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Remediation mode to use after approval. When omitted, the remediation keeps its existing mode.
/// <list type="bullet">
///   <item><description><c>REMEDIATION_MODE_VM_ONLY</c>: Deletes the VM and provisions a new one on any available host.</description></item>
///   <item><description><c>REMEDIATION_MODE_HOST_AWARE</c>: Cordons the host, deletes the VM, and provisions a new one on a different host.</description></item>
///   <item><description><c>REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT</c>: Evicts the VM without provisioning a replacement.</description></item>
///   <item><description><c>REMEDIATION_MODE_REBOOT_VM</c>: Reboots the VM in place.</description></item>
///   <item><description><c>REMEDIATION_MODE_HOST_POWER_CYCLE</c>: Power-cycles the bare-metal host after cordoning it. This mode cannot be set as an approval override; create a host power-cycle remediation directly.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Mode1>))]
public sealed record Mode1 : OpenStringEnum<Mode1>
{
    private Mode1(string value) : base(value)
    {
    }

    public static readonly Mode1 RemediationModeVmOnly = new("REMEDIATION_MODE_VM_ONLY");

    public static readonly Mode1 RemediationModeHostAware = new("REMEDIATION_MODE_HOST_AWARE");

    public static readonly Mode1 RemediationModeEvictWithoutReplacement = new(
        "REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT");

    public static readonly Mode1 RemediationModeRebootVm = new("REMEDIATION_MODE_REBOOT_VM");

    public static readonly Mode1 RemediationModeHostPowerCycle = new("REMEDIATION_MODE_HOST_POWER_CYCLE");

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
