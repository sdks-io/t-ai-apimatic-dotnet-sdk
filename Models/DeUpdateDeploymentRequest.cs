using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Mutable deployment settings. Use the resource-name fields or their deprecated ID alternatives for a model or config change, but not both.
/// </summary>
public record DeUpdateDeploymentRequest
{
    /// <summary>
    /// Updated endpoint string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Updated autoscaling configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoscaling")]
    public DeAutoscaling? Autoscaling { get; init; }

    /// <summary>
    /// Updated inactive timeout in minutes. Use 0 to disable automatic stopping; otherwise accepted values are 30 through 1440.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactiveTimeout")]
    public int? InactiveTimeout { get; init; }

    /// <summary>
    /// Updated maximum number of inference requests that may be in flight to a single replica. Values above the deployment config's per-replica concurrency limit minus one are reduced on update; 0 means unlimited when the config limit is 1 or less. Changes take effect without restarting replicas.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxConcurrentRequestsPerReplica")]
    public string? MaxConcurrentRequestsPerReplica { get; init; }

    /// <summary>
    /// Current deployment version. The update is rejected if this value no longer matches.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("etag")]
    public string? Etag { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
