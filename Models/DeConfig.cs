using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Resolved inference engine, orchestration framework, and selectors for one config revision.
/// </summary>
public record DeConfig
{
    /// <summary>
    /// Unique config revision identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Inference engine used to serve the model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("engineType")]
    public EngineType? EngineType { get; init; }

    /// <summary>
    /// Orchestration framework used to run replicas for this config.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deploymentFramework")]
    public DeploymentFramework? DeploymentFramework { get; init; }

    /// <summary>
    /// Hardware and runtime selectors resolved by the config.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selectors")]
    public IReadOnlyList<DeConfigSelector>? Selectors { get; init; }

    /// <summary>
    /// Stable hash of the resolved selectors, used to identify equivalent configs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selectorsHash")]
    public string? SelectorsHash { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
