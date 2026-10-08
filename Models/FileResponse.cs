using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Structured information describing a file uploaded to Together.
/// </summary>
public record FileResponse
{
    /// <summary>
    /// ID of the file.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The object type, which is always <c>file</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "file";

    /// <summary>
    /// The timestamp when the file was created.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required int CreatedAt { get; init; }

    /// <summary>
    /// The name of the file as it was uploaded.
    /// </summary>
    [JsonPropertyName("filename")]
    public required string Filename { get; init; }

    /// <summary>
    /// The number of bytes in the file.
    /// </summary>
    [JsonPropertyName("bytes")]
    public required int Bytes { get; init; }

    /// <summary>
    /// The purpose of the file as it was uploaded.
    /// </summary>
    [JsonPropertyName("purpose")]
    public required FilePurpose2 Purpose { get; init; }

    /// <summary>
    /// Deprecated. Whether file has been fully uploaded.
    /// </summary>
    [JsonPropertyName("Processed")]
    public required bool Processed { get; init; }

    /// <summary>
    /// The type of the file such as <c>jsonl</c>, <c>csv</c>, or <c>parquet</c>.
    /// </summary>
    [JsonPropertyName("FileType")]
    public FileType2 FileType { get; init; } = FileType2.Jsonl;

    /// <summary>
    /// Lifecycle state of the file validation pipeline. Files for
    /// non-<c>fine-tune</c> purposes skip validation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processing_status")]
    public FileProcessingStatus2? ProcessingStatus { get; init; }

    /// <summary>
    /// Report produced by the file validation pipeline. Present once
    /// validation has run; absent on files that bypassed validation
    /// (non-<c>fine-tune</c> purposes) or have not yet been validated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validation_report")]
    public FileValidationReport2? ValidationReport { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
