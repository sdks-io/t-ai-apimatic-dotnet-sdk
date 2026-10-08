using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.Files;

/// <summary>
/// The inputs of the UploadAFile operation.
/// </summary>
public sealed record UploadAFileRequest
{
    /// <summary>
    /// The purpose of the file
    /// </summary>
    public required FilePurpose Purpose { get; init; }

    /// <summary>
    /// The name of the file being uploaded. Must be valid UTF-8, must not contain null characters, and must not exceed 128 bytes.
    /// </summary>
    public required string FileName { get; init; }

    /// <summary>
    /// The content of the file being uploaded
    /// </summary>
    public required BinaryContent File { get; init; }

    /// <summary>
    /// The type of the file
    /// </summary>
    public FileType FileType { get; init; } = FileType.Jsonl;
}
