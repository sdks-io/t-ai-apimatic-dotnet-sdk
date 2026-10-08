using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// JSON object response format. An older method of generating JSON responses.
/// Using <c>json_schema</c> is recommended for models that support it. Note that the
/// model will not generate JSON without a system or user message instructing it
/// to do so.
/// </summary>
public record JsonObject
{
    /// <summary>
    /// The type of response format being defined. Always <c>json_object</c>.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "json_object";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
