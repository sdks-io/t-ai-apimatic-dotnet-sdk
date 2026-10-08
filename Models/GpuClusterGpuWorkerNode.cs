using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record GpuClusterGpuWorkerNode
{
    [JsonPropertyName("node_id")]
    public required string NodeId { get; init; }

    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonPropertyName("host_name")]
    public required string HostName { get; init; }

    [JsonPropertyName("num_cpu_cores")]
    public required int NumCpuCores { get; init; }

    [JsonPropertyName("num_gpus")]
    public required int NumGpus { get; init; }

    [JsonPropertyName("memory_gib")]
    public required double MemoryGib { get; init; }

    [JsonPropertyName("networks")]
    public required IReadOnlyList<string> Networks { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instance_id")]
    public string? InstanceId { get; init; }

    /// <summary>
    /// Remediation represents a node remediation request for an instance.
    /// An instance can have multiple remediations over time (e.g., failed attempts followed by retries).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latest_remediation")]
    public Remediation? LatestRemediation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("slurm_worker_hostname")]
    public string? SlurmWorkerHostname { get; init; }

    /// <summary>
    /// Phase transition history for this GPU worker node.
    /// </summary>
    [JsonPropertyName("phase_transitions")]
    public required IReadOnlyList<NodePhaseTransition> PhaseTransitions { get; init; }

    /// <summary>
    /// Whether this node is marked for deletion by the operator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("marked_for_deletion")]
    public bool? MarkedForDeletion { get; init; }

    /// <summary>
    /// Public IPv4 address of the GPU worker node.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("public_ipv4")]
    public string? PublicIpv4 { get; init; }

    /// <summary>
    /// InfiniBand HCA type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ib_hca_type")]
    public string? IbHcaType { get; init; }

    /// <summary>
    /// Number of InfiniBand HCAs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ib_hca_count")]
    public int? IbHcaCount { get; init; }

    /// <summary>
    /// Number of NVSwitches.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nvswitch_count")]
    public int? NvswitchCount { get; init; }

    /// <summary>
    /// NVSwitch type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nvswitch_type")]
    public string? NvswitchType { get; init; }

    /// <summary>
    /// Ephemeral storage size, such as 1Ti.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ephemeral_storage")]
    public string? EphemeralStorage { get; init; }

    /// <summary>
    /// Whether auto-remediation is enabled for this node's instance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_remediation_enabled")]
    public bool? AutoRemediationEnabled { get; init; }

    /// <summary>
    /// Timestamp when the node left the live data plane. Only set for deleted_gpu_worker_nodes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deleted_at")]
    public DateTimeOffset? DeletedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
