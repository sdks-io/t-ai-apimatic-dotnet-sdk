using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

public record EmbeddingsRequest
{
    /// <summary>
    /// The name of the embedding model to use.&lt;br&gt; &lt;br&gt; <see href="https://docs.together.ai/docs/serverless-models#embedding-models">See all of Together AI's embedding models</see>
    /// </summary>
    [JsonPropertyName("model")]
    public required Model51 Model { get; init; }

    [JsonPropertyName("input")]
    public required Input Input { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
