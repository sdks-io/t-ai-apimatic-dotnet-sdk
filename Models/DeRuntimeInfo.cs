using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Runtime information derived from the deployment's configuration.
/// </summary>
public record DeRuntimeInfo
{
    /// <summary>
    /// Serving engine, such as <c>vllm</c>, <c>trtllm</c>, or <c>sglang</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("engineType")]
    public string? EngineType { get; init; }

    /// <summary>
    /// Version of the serving engine.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; init; }

    /// <summary>
    /// Whether the runtime accepts tool and function-calling requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("functionCallingSupported")]
    public bool? FunctionCallingSupported { get; init; }

    /// <summary>
    /// Whether the runtime can constrain generation to a structured output schema.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("structuredOutputSupported")]
    public bool? StructuredOutputSupported { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
