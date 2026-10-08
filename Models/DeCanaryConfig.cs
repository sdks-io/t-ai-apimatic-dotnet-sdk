using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Canary strategy configuration for gradual traffic progression. An empty config uses the default 5, 25, 50, 100 percent ladder; over a frozen traffic-split pair left by cancel, the default ladder is derived at start from the pair's current served share so it begins above it.
/// </summary>
public record DeCanaryConfig
{
    /// <summary>
    /// Optional progression steps. Defaults to 5, 25, 50, 100 percent when empty; explicit steps must increase and end at 100 percent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("steps")]
    public IReadOnlyList<DeRolloutStep>? Steps { get; init; }

    /// <summary>
    /// Optional positive soak between steps. Defaults to 3m if omitted, and grows to cover metric rule windows plus ingestion lag.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stepInterval")]
    [RegularExpression("^-?(?:0|[1-9][0-9]{0,11})(?:\\.[0-9]{1,9})?s$")]
    public string? StepInterval { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
