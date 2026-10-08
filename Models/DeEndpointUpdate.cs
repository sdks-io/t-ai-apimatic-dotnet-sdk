using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Mutable endpoint fields for update requests.
/// </summary>
public record DeEndpointUpdate
{
    /// <summary>
    /// Updated endpoint string.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Current endpoint version. The update is rejected if this value no longer matches.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("etag")]
    public string? Etag { get; init; }

    /// <summary>
    /// Replacement live traffic split. Use an empty list to stop routing live traffic.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trafficSplit")]
    public IReadOnlyList<DeTrafficSplitEntry>? TrafficSplit { get; init; }

    /// <summary>
    /// Who can discover the endpoint. <c>VISIBILITY_PRIVATE</c> restricts it to the project; <c>VISIBILITY_INTERNAL</c> shares it with the organization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visibility")]
    public Visibility? Visibility { get; init; } = Visibility.VisibilityPrivate;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
