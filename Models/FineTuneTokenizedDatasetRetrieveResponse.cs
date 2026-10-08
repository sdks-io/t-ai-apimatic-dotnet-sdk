using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Validation;
using TogetherApIs.Core.Validation.Attributes;

namespace TogetherApIs.Models;

/// <summary>
/// Presigned download metadata for a fine-tune tokenized dataset archive.
/// </summary>
public record FineTuneTokenizedDatasetRetrieveResponse
{
    /// <summary>
    /// Presigned URL for downloading the tokenized dataset archive.
    /// </summary>
    [JsonPropertyName("url")]
    [Format(FormatKind.Uri)]
    public required string Url { get; init; }

    /// <summary>
    /// Archive filename to use when saving the downloaded tokenized dataset.
    /// </summary>
    [JsonPropertyName("filename")]
    public required string Filename { get; init; }

    /// <summary>
    /// Archive size in bytes.
    /// </summary>
    [JsonPropertyName("size")]
    public required int Size { get; init; }

    /// <summary>
    /// MIME type for the tokenized dataset archive.
    /// </summary>
    [JsonPropertyName("content_type")]
    public required string ContentType { get; init; }

    /// <summary>
    /// Time when the presigned download URL expires.
    /// </summary>
    [JsonPropertyName("expires_at")]
    public required DateTimeOffset ExpiresAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
