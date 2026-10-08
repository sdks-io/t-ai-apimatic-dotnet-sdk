using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Request body identifying the deployment revision to roll back to.
/// </summary>
public record RollbackDeploymentRequest
{
    /// <summary>
    /// Revision number or revision ID to roll back to.
    /// </summary>
    [JsonPropertyName("revision_identifier")]
    public required string RevisionIdentifier { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
