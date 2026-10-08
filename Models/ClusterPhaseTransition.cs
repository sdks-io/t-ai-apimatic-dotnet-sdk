using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record ClusterPhaseTransition
{
    /// <summary>
    /// Cluster phase.
    /// </summary>
    [JsonPropertyName("phase")]
    public required Phase1 Phase { get; init; }

    /// <summary>
    /// Timestamp when the phase transition occurred.
    /// </summary>
    [JsonPropertyName("transition_time")]
    public required DateTimeOffset TransitionTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
