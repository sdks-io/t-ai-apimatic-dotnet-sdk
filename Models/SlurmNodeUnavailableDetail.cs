using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Details for a Slurm node unavailable passive health check alert.
/// </summary>
public record SlurmNodeUnavailableDetail
{
    /// <summary>
    /// Drain reason reported for the unavailable Slurm node.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
