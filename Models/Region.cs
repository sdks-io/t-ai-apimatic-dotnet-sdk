using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record Region
{
    /// <summary>
    /// Identifiable name of the region.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// List of supported identifiable cuda/nvidia driver versions pairs available in the region.
    /// </summary>
    [JsonPropertyName("driver_versions")]
    public required IReadOnlyList<ClusterDriverVersionInfo> DriverVersions { get; init; }

    /// <summary>
    /// List of supported identifiable gpus available in the region.
    /// </summary>
    [JsonPropertyName("supported_instance_types")]
    public required IReadOnlyList<string> SupportedInstanceTypes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
