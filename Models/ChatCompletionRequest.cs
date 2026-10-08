using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Validation.Attributes;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;
using TogetherApIs.Models.OneOf;

namespace TogetherApIs.Models;

public record ChatCompletionRequest
{
    /// <summary>
    /// A list of messages comprising the conversation so far.
    /// </summary>
    [JsonPropertyName("messages")]
    public required IReadOnlyList<ChatCompletionMessageParam> Messages { get; init; }

    /// <summary>
    /// The name of the model to query.&lt;br&gt; &lt;br&gt; <see href="https://docs.together.ai/docs/serverless-models#chat-models">See all of Together AI's chat models</see>
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// The maximum number of tokens to generate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_tokens")]
    public int? MaxTokens { get; init; }

    /// <summary>
    /// A list of string sequences that truncate (stop) inference text output. For example, "&lt;/s&gt;" stops generation as soon as the model generates the given token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stop")]
    public IReadOnlyList<string>? Stop { get; init; }

    /// <summary>
    /// A decimal number from 0-1 that determines the degree of randomness in the response. A temperature less than 1 favors more correctness and is appropriate for question answering or summarization. A value closer to 1 introduces more randomness in the output.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("temperature")]
    public double? Temperature { get; init; }

    /// <summary>
    /// A percentage (also called the nucleus parameter) that's used to dynamically adjust the number of choices for each predicted token based on the cumulative probabilities. It specifies a probability threshold below which all less likely tokens are filtered out. This technique helps maintain diversity and generate more fluent and natural-sounding text.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("top_p")]
    public double? TopP { get; init; }

    /// <summary>
    /// An integer that's used to limit the number of choices for the next predicted word or token. It specifies the maximum number of tokens to consider at each step, based on their probability of occurrence. This technique helps to speed up the generation process and can improve the quality of the generated text by focusing on the most likely options.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("top_k")]
    public int? TopK { get; init; }

    /// <summary>
    /// Defines the behavior of the API when max_tokens exceed the maximum context length of the model. When set to 'error', the API returns 400 with an appropriate error message. When set to 'truncate', overrides max_tokens with the maximum context length of the model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("context_length_exceeded_behavior")]
    public ContextLengthExceededBehavior? ContextLengthExceededBehavior { get; init; } = ContextLengthExceededBehavior.Error;

    /// <summary>
    /// A number that controls the diversity of generated text by reducing the likelihood of repeated sequences. Higher values decrease repetition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("repetition_penalty")]
    public double? RepetitionPenalty { get; init; }

    /// <summary>
    /// If true, stream tokens as Server-Sent Events as the model generates them instead of waiting for the full model response. The stream terminates with <c>data: [DONE]</c>. If false, return a single JSON object containing the results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stream")]
    public bool? Stream { get; init; }

    /// <summary>
    /// An integer between 0 and 20 of the top k tokens to return log probabilities for at each generation step, instead of only the sampled token. Log probabilities help assess model confidence in token predictions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logprobs")]
    [Minimum(0)]
    [Maximum(20)]
    public int? Logprobs { get; init; }

    /// <summary>
    /// If true, the response contains the prompt. Can be used with <c>logprobs</c> to return prompt logprobs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("echo")]
    public bool? Echo { get; init; }

    /// <summary>
    /// The number of completions to generate for each prompt.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("n")]
    [Minimum(1)]
    [Maximum(128)]
    public int? N { get; init; }

    /// <summary>
    /// A number between 0 and 1 that can be used as an alternative to top_p and top-k.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_p")]
    public double? MinP { get; init; }

    /// <summary>
    /// A number between -2.0 and 2.0 where a positive value increases the likelihood of a model talking about new topics.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("presence_penalty")]
    public double? PresencePenalty { get; init; }

    /// <summary>
    /// A number between -2.0 and 2.0 where a positive value decreases the likelihood of repeating tokens that have already been mentioned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frequency_penalty")]
    public double? FrequencyPenalty { get; init; }

    /// <summary>
    /// Adjusts the likelihood of specific tokens appearing in the generated output.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logit_bias")]
    public IReadOnlyDictionary<string, double>? LogitBias { get; init; }

    /// <summary>
    /// Seed value for reproducibility.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seed")]
    public int? Seed { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("function_call")]
    public FunctionCall32? FunctionCall { get; init; }

    /// <summary>
    /// An object specifying the format that the model must output.
    /// <para>
    /// Setting to <c>{ "type": "json_schema", "json_schema": {...} }</c> enables
    /// Structured Outputs which ensures the model will match your supplied JSON
    /// schema. Learn more in the [Structured Outputs
    /// guide](https://docs.together.ai/docs/json-mode).
    /// </para>
    /// <para>
    /// Setting to <c>{ "type": "json_object" }</c> enables the older JSON mode, which
    /// ensures the message the model generates is valid JSON. Using <c>json_schema</c>
    /// is preferred for models that support it.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_format")]
    public ResponseFormat2? ResponseFormat { get; init; }

    /// <summary>
    /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tools")]
    public IReadOnlyList<ToolsPart>? Tools { get; init; }

    /// <summary>
    /// Controls which (if any) function is called by the model. By default uses <c>auto</c>, which lets the model pick between generating a message or calling a function.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tool_choice")]
    public ToolChoice1? ToolChoice { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("compliance")]
    public Compliance? Compliance { get; init; }

    /// <summary>
    /// Additional configuration to pass to model engine.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chat_template_kwargs")]
    public object? ChatTemplateKwargs { get; init; }

    /// <summary>
    /// The name of the moderation model used to validate tokens. Choose from the available moderation models found <see href="https://docs.together.ai/docs/inference-models#moderation-models">here</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("safety_model")]
    public string? SafetyModel { get; init; }

    /// <summary>
    /// Controls the level of reasoning effort the model should apply when generating responses. Higher values may result in more thoughtful and detailed responses but may take longer to generate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reasoning_effort")]
    public ReasoningEffort? ReasoningEffort { get; init; }

    /// <summary>
    /// For models that support toggling reasoning functionality, this object can be used to control that functionality.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reasoning")]
    public Reasoning? Reasoning { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
