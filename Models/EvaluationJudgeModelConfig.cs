using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Validation.Attributes;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record EvaluationJudgeModelConfig
{
    /// <summary>
    /// Name of the judge model
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// System prompt template for the judge
    /// </summary>
    [JsonPropertyName("system_template")]
    public required string SystemTemplate { get; init; }

    /// <summary>
    /// Source of the judge model inference: - <c>serverless</c>: Together's shared serverless inference API. Default concurrency: 25 workers. - <c>dedicated</c>: A Together dedicated deployment endpoint. Default concurrency: 5 workers
    ///   (minimum enforced even if num_workers is set lower).
    /// - <c>external</c>: An external inference API (e.g. OpenAI, Anthropic, Google, OpenRouter).
    ///   Requires <c>external_api_token</c> and <c>external_base_url</c>. Default concurrency: 2 workers
    ///   for first-party APIs, 20 for proxy/aggregator endpoints.
    /// </summary>
    [JsonPropertyName("model_source")]
    public required ModelSource ModelSource { get; init; }

    /// <summary>
    /// Bearer/API token for the external judge model provider. Required when model_source is 'external'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_api_token")]
    public string? ExternalApiToken { get; init; }

    /// <summary>
    /// Base URL of the external inference API for the judge. Must be OpenAI-compatible. Required when model_source is 'external'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_base_url")]
    public string? ExternalBaseUrl { get; init; }

    /// <summary>
    /// Number of concurrent inference workers for the judge. Overrides the source-specific default (serverless: 25, dedicated: 5, external: 2–20). For dedicated endpoints the value is clamped to a minimum of 5 regardless of what is set here.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_workers")]
    [Minimum(1)]
    public int? NumWorkers { get; init; }

    /// <summary>
    /// Maximum number of tokens the judge model may generate. Defaults to 32768 if omitted. Set higher for reasoning judges (e.g. o-series, Gemini) that spend tokens on internal chain-of-thought before emitting the verdict JSON.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_tokens")]
    [Minimum(1)]
    public int? MaxTokens { get; init; }

    /// <summary>
    /// Sampling temperature for the judge model. Defaults to 0.05 if omitted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("temperature")]
    [Minimum(0.0)]
    [Maximum(2.0)]
    public double? Temperature { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
