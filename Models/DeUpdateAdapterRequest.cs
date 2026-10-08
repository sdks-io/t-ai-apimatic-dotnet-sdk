using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Request body for updating an adapter.
/// </summary>
public record DeUpdateAdapterRequest
{
    /// <summary>
    /// New adapter revision to pin.
    /// </summary>
    [JsonPropertyName("adapterRevisionId")]
    public required string AdapterRevisionId { get; init; }

    /// <summary>
    /// Row-level etag from a prior AddAdapter, UpdateAdapter, GetAdapter, or ListAdapters response.
    /// </summary>
    [JsonPropertyName("etag")]
    public required string Etag { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
