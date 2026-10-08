using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Request parameters for creating a remote upload.
/// </summary>
public record DeCreateRemoteUploadSpec
{
    /// <summary>
    /// ID of the registered model that will receive the imported files.
    /// </summary>
    [JsonPropertyName("modelId")]
    public required string ModelId { get; init; }

    /// <summary>
    /// Hugging Face repository URL or presigned archive URL to import.
    /// </summary>
    [JsonPropertyName("remoteUrl")]
    public required string RemoteUrl { get; init; }

    /// <summary>
    /// Optional source credential used to access a private remote location. The value is write-only and is not returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token")]
    public string? Token { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
