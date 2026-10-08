using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record GpuClusterControlPlaneNode
{
    [JsonPropertyName("node_id")]
    public required string NodeId { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("host_name")]
    public required string HostName { get; init; }

    [JsonPropertyName("num_cpu_cores")]
    public required int NumCpuCores { get; init; }

    [JsonPropertyName("memory_gib")]
    public required double MemoryGib { get; init; }

    [JsonPropertyName("network")]
    public required string Network { get; init; }

    /// <summary>
    /// Phase transition history for this control plane node.
    /// </summary>
    [JsonPropertyName("phase_transitions")]
    public required IReadOnlyList<NodePhaseTransition> PhaseTransitions { get; init; }

    /// <summary>
    /// Public IPv4 address of the control plane node.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("public_ipv4")]
    public string? PublicIpv4 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
