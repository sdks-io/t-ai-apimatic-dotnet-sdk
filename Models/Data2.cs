using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;
using TogetherApIs.Models.OneOf;

namespace TogetherApIs.Models;

public record Data2
{
    [JsonPropertyName("outputs")]
    public required IReadOnlyList<InterpreterOutput> Outputs { get; init; }

    /// <summary>
    /// Identifier of the current session. Used to make follow-up calls.
    /// </summary>
    [JsonPropertyName("session_id")]
    public required string SessionId { get; init; }

    /// <summary>
    /// Status of the execution. Currently only supports success.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status6? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
