using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record InstanceClusterConfig
{
    [JsonPropertyName("load_balancer")]
    public required LoadBalancer LoadBalancer { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kubernetes_dashboard_enabled")]
    public bool? KubernetesDashboardEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jumphost_enabled")]
    public bool? JumphostEnabled { get; init; }

    /// <summary>
    /// SlurmStartupScripts carries optional Slurm lifecycle scripts (prolog/epilog, init, extra conf).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("slurm_startup_scripts")]
    public SlurmStartupScripts? SlurmStartupScripts { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ingress")]
    public ClusterIngressConfig? Ingress { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("observability")]
    public ObservabilityConfig? Observability { get; init; }

    /// <summary>
    /// NVIDIA GPU Operator chart/version for the tenant cluster (e.g. v24.6.2). When omitted, a service default is applied.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gpu_operator_version")]
    public string? GpuOperatorVersion { get; init; }

    /// <summary>
    /// NVIDIA Network Operator chart/version for the tenant cluster (e.g. v24.7.0). When omitted, a service default is applied.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("network_operator_version")]
    public string? NetworkOperatorVersion { get; init; }

    /// <summary>
    /// Whether this cluster uses a per-cluster SSH certificate authority for OIDC-signed SSH access.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ssh_ca_enabled")]
    public bool? SshCaEnabled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
