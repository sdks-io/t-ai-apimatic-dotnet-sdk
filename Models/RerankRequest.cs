using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

public record RerankRequest
{
    /// <summary>
    /// The model to be used for the rerank request.&lt;br&gt; &lt;br&gt; <see href="https://docs.together.ai/docs/serverless-models#rerank-models">See all of Together AI's rerank models</see>
    /// </summary>
    [JsonPropertyName("model")]
    public required Model7 Model { get; init; }

    /// <summary>
    /// The search query to be used for ranking.
    /// </summary>
    [JsonPropertyName("query")]
    public required string Query { get; init; }

    /// <summary>
    /// List of documents, which can be either strings or objects.
    /// </summary>
    [JsonPropertyName("documents")]
    public required Documents Documents { get; init; }

    /// <summary>
    /// The number of top results to return.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("top_n")]
    public int? TopN { get; init; }

    /// <summary>
    /// Whether to return supplied documents with the response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_documents")]
    public bool? ReturnDocuments { get; init; }

    /// <summary>
    /// List of keys in the JSON Object document to rank by. Defaults to use all supplied keys for ranking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rank_fields")]
    public IReadOnlyList<string>? RankFields { get; init; }
}
