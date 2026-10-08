using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record ExecuteRequest
{
    /// <summary>
    /// Code snippet to execute.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>
    /// Files to upload to the session. If present, files are uploaded before executing the given code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("files")]
    public IReadOnlyList<object>? Files { get; init; }

    /// <summary>
    /// Programming language for the code to execute. Currently only supports Python.
    /// </summary>
    [JsonPropertyName("language")]
    public string Language { get; } = "python";

    /// <summary>
    /// Identifier of the current session. Used to make follow-up calls. Returns an error if the session does not belong to the caller or has expired.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("session_id")]
    public string? SessionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
