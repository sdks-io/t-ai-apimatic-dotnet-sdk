using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Configuration for a cluster add-on.
/// </summary>
public record AddOnConfig
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dashboard")]
    public DashboardConfig? Dashboard { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ingress")]
    public IngressConfig? Ingress { get; init; }

    /// <summary>
    /// Configuration for the Model Aware TorchPass add-on.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("torchpass")]
    public TorchpassConfig2? Torchpass { get; init; }

    /// <summary>
    /// Configuration for the Slurm Web add-on.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("slurm_web")]
    public SlurmWebConfig2? SlurmWeb { get; init; }

    /// <summary>
    /// Configuration for the Headlamp Kubernetes dashboard add-on.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headlamp")]
    public HeadlampConfig2? Headlamp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
