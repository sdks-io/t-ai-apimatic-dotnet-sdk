using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Request body for approving a pending remediation.
/// </summary>
public record ApproveRemediationRequest
{
    /// <summary>
    /// Approval comment explaining the decision.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("comment")]
    public string? Comment { get; init; }

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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mode")]
    public Mode1? Mode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
