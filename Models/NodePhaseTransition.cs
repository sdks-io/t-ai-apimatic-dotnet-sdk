using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record NodePhaseTransition
{
    /// <summary>
    /// Node phase.
    /// </summary>
    [JsonPropertyName("phase")]
    public required Phase Phase { get; init; }

    /// <summary>
    /// Timestamp when the phase transition occurred.
    /// </summary>
    [JsonPropertyName("transition_time")]
    public required DateTimeOffset TransitionTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
