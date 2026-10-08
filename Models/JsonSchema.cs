using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// JSON Schema response format. Used to generate structured JSON responses.
/// Learn more about <see href="https://docs.together.ai/docs/json-mode">Structured Outputs</see>.
/// </summary>
public record JsonSchema
{
    /// <summary>
    /// The type of response format being defined. Always <c>json_schema</c>.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "json_schema";

    /// <summary>
    /// Structured Outputs configuration options, including a JSON Schema.
    /// </summary>
    [JsonPropertyName("json_schema")]
    public required JsonSchema1 JsonSchemaValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
