using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record ModelUploadRequest
{
    /// <summary>
    /// The name to give to your uploaded model
    /// </summary>
    [JsonPropertyName("model_name")]
    public required string ModelName { get; init; }

    /// <summary>
    /// The source location of the model (Hugging Face repo or S3 path)
    /// </summary>
    [JsonPropertyName("model_source")]
    public required string ModelSource { get; init; }

    /// <summary>
    /// Whether the model is a full model or an adapter
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_type")]
    public ModelType? ModelType { get; init; } = ModelType.Model;

    /// <summary>
    /// Hugging Face token (if uploading from Hugging Face)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hf_token")]
    public string? HfToken { get; init; }

    /// <summary>
    /// A description of your model
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The base model to use for an adapter if setting it to run against a serverless pool.  Only used for model_type <c>adapter</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_model")]
    public string? BaseModel { get; init; }

    /// <summary>
    /// The lora pool to use for an adapter if setting it to run against, say, a dedicated pool.  Only used for model_type <c>adapter</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lora_model")]
    public string? LoraModel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
