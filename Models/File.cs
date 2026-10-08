using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record File
{
    [JsonPropertyName("content")]
    public required string Content { get; init; }

    /// <summary>
    /// Encoding of the file content. Use <c>string</c> for text files such as code, and <c>base64</c> for binary files, such as images.
    /// </summary>
    [JsonPropertyName("encoding")]
    public required Encoding Encoding { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
