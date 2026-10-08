using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// A non-blocking finding attached to a rollout defaults preview; expected end-state facts are structured fields on RolloutDefaultsPreview.
/// </summary>
public record DePreviewWarning
{
    /// <summary>
    /// Machine-readable warning code. Current vocabulary is START_WILL_REJECT, FINAL_BELOW_SOURCE_MIN, and FIRST_STEP_AT_SEED; render message for unrecognized codes.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>
    /// Plain-language description of the finding, safe to show users as-is.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
