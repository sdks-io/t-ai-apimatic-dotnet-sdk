using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Validation.Attributes;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record EvaluationModelRequest
{
    /// <summary>
    /// Name of the model to evaluate
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Maximum number of tokens to generate.
    /// </summary>
    [JsonPropertyName("max_tokens")]
    [Minimum(1)]
    public required int MaxTokens { get; init; }

    /// <summary>
    /// Sampling temperature for generation.
    /// </summary>
    [JsonPropertyName("temperature")]
    [Minimum(0.0)]
    [Maximum(2.0)]
    public required double Temperature { get; init; }

    /// <summary>
    /// System prompt template. Supports Jinja2 variables referencing dataset columns.
    /// </summary>
    [JsonPropertyName("system_template")]
    public required string SystemTemplate { get; init; }

    /// <summary>
    /// User message template. Supports Jinja2 variables referencing dataset columns.
    /// </summary>
    [JsonPropertyName("input_template")]
    public required string InputTemplate { get; init; }

    /// <summary>
    /// Source of the model inference: - <c>serverless</c>: Together's shared serverless inference API. Default concurrency: 25 workers. - <c>dedicated</c>: A Together dedicated deployment endpoint. Default concurrency: 5 workers
    ///   (minimum enforced even if num_workers is set lower). Authentication uses the requesting
    ///   user's Together API token automatically.
    /// - <c>external</c>: An external inference API (e.g. OpenAI, Anthropic, Google, OpenRouter).
    ///   Requires <c>external_api_token</c> and <c>external_base_url</c>. Default concurrency: 2 workers
    ///   for first-party APIs (OpenAI, Anthropic, Google), 20 for proxy/aggregator endpoints.
    /// </summary>
    [JsonPropertyName("model_source")]
    public required ModelSource1 ModelSource { get; init; }

    /// <summary>
    /// Bearer/API token for the external model provider. Required when model_source is 'external'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_api_token")]
    public string? ExternalApiToken { get; init; }

    /// <summary>
    /// Base URL of the external inference API. Must be OpenAI-compatible. Required when model_source is 'external'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_base_url")]
    public string? ExternalBaseUrl { get; init; }

    /// <summary>
    /// Number of concurrent inference workers. Overrides the source-specific default (serverless: 25, dedicated: 5, external: 2–20). For dedicated endpoints the value is clamped to a minimum of 5 regardless of what is set here.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_workers")]
    [Minimum(1)]
    public int? NumWorkers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
