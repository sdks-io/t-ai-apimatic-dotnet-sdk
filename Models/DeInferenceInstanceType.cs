using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// GPU hardware configuration on which one inference replica can run.
/// </summary>
public record DeInferenceInstanceType
{
    /// <summary>
    /// Stable hardware instance type identifier used by deployment configs.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Human-readable instance type name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Human-readable summary of the hardware configuration.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// GPU accelerator model, such as <c>H100</c> or <c>B200</c>.
    /// </summary>
    [JsonPropertyName("gpuType")]
    public required string GpuType { get; init; }

    /// <summary>
    /// Number of GPUs in one replica of this instance type.
    /// </summary>
    [JsonPropertyName("gpuCount")]
    public required int GpuCount { get; init; }

    /// <summary>
    /// Memory available on each GPU, in GiB.
    /// </summary>
    [JsonPropertyName("gpuMemoryGib")]
    public required int GpuMemoryGib { get; init; }

    /// <summary>
    /// On-demand price for one running replica, in US cents per hour.
    /// </summary>
    [JsonPropertyName("priceCentsPerHour")]
    public required int PriceCentsPerHour { get; init; }

    /// <summary>
    /// Regions where this instance type is offered.
    /// </summary>
    [JsonPropertyName("regions")]
    public required IReadOnlyList<DeRegion> Regions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
