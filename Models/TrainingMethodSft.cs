using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

public record TrainingMethodSft
{
    [JsonPropertyName("method")]
    public string Method { get; } = "sft";

    /// <summary>
    /// Whether to mask user messages in conversational data or prompts in instruction data.
    /// </summary>
    [JsonPropertyName("train_on_inputs")]
    public required TrainOnInputs11 TrainOnInputs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
