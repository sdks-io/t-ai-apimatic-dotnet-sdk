using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Typed content parsed from passive health check alert annotations.
/// </summary>
public record PhcAnnotation
{
    /// <summary>
    /// Alert title from the Alertmanager summary annotation.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; init; }

    /// <summary>
    /// Static explanation for the alert.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// Per-firing summary line parsed from the evidence annotation.
    /// </summary>
    [JsonPropertyName("summary_line")]
    public required string SummaryLine { get; init; }

    /// <summary>
    /// Xid-specific details when the alert was caused by NVIDIA Xid errors.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("xid")]
    public XidDetail? Xid { get; init; }

    /// <summary>
    /// Slurm node details when the alert was caused by unavailable Slurm nodes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("slurm_node_unavailable")]
    public SlurmNodeUnavailableDetail? SlurmNodeUnavailable { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
