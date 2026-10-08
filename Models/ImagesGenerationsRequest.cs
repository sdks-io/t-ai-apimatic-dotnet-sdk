using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record ImagesGenerationsRequest
{
    /// <summary>
    /// A description of the desired images. Maximum length varies by model.
    /// </summary>
    [JsonPropertyName("prompt")]
    public required string Prompt { get; init; }

    /// <summary>
    /// The model to use for image generation.&lt;br&gt; &lt;br&gt; <see href="https://docs.together.ai/docs/serverless-models#image-models">See all of Together AI's image models</see>
    /// </summary>
    [JsonPropertyName("model")]
    public required Model61 Model { get; init; }

    /// <summary>
    /// Number of generation steps.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("steps")]
    public int? Steps { get; init; } = 20;

    /// <summary>
    /// URL of an image to use for image models that support it.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; init; }

    /// <summary>
    /// Seed used for generation. Can be used to reproduce image generations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seed")]
    public int? Seed { get; init; }

    /// <summary>
    /// Number of image results to generate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("n")]
    public int? N { get; init; } = 1;

    /// <summary>
    /// Height of the image to generate in number of pixels.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("height")]
    public int? Height { get; init; } = 1024;

    /// <summary>
    /// Width of the image to generate in number of pixels.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("width")]
    public int? Width { get; init; } = 1024;

    /// <summary>
    /// The prompt or prompts not to guide the image generation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("negative_prompt")]
    public string? NegativePrompt { get; init; }

    /// <summary>
    /// Format of the image response. Can be either a base64 string or a URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response_format")]
    public ResponseFormat3? ResponseFormat { get; init; }

    /// <summary>
    /// Adjusts the alignment of the generated image with the input prompt. Higher values (e.g., 8-10) make the output more faithful to the prompt, while lower values (e.g., 1-5) encourage more creative freedom.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("guidance_scale")]
    public double? GuidanceScale { get; init; } = 3.5d;

    /// <summary>
    /// The format of the image response. Can be either be <c>jpeg</c> or <c>png</c>. Defaults to <c>jpeg</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("output_format")]
    public OutputFormat? OutputFormat { get; init; } = OutputFormat.Jpeg;

    /// <summary>
    /// An array of objects that define LoRAs (Low-Rank Adaptations) to influence the generated image.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image_loras")]
    public IReadOnlyList<ImageLora>? ImageLoras { get; init; }

    /// <summary>
    /// An array of image URLs that guide the overall appearance and style of the generated image. These reference images influence the visual characteristics consistently across the generation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_images")]
    public IReadOnlyList<string>? ReferenceImages { get; init; }

    /// <summary>
    /// If true, disables the safety checker for image generation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disable_safety_checker")]
    public bool? DisableSafetyChecker { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
