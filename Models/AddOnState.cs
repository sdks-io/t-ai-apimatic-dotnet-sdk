using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// State for a cluster add-on.
/// </summary>
public record AddOnState
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dashboard")]
    public object? Dashboard { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ingress")]
    public object? Ingress { get; init; }

    /// <summary>
    /// State for the Model Aware TorchPass add-on.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("torchpass")]
    public object? Torchpass { get; init; }

    /// <summary>
    /// State for the Slurm Web add-on.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("slurm_web")]
    public object? SlurmWeb { get; init; }

    /// <summary>
    /// State for the Headlamp Kubernetes dashboard add-on.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headlamp")]
    public object? Headlamp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
