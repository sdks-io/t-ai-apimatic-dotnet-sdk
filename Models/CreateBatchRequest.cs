using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record CreateBatchRequest
{
    /// <summary>
    /// The endpoint to use for batch processing. Each line of the uploaded input file is dispatched against this endpoint.
    /// - <c>/v1/chat/completions</c> — chat completion batches
    /// - <c>/v1/audio/transcriptions</c> — audio transcription batches (e.g. <c>openai/whisper-large-v3</c>)
    /// - <c>/v1/audio/translations</c> — audio translation batches
    /// </summary>
    [JsonPropertyName("endpoint")]
    public required Endpoint Endpoint { get; init; }

    /// <summary>
    /// ID of the uploaded input file containing batch requests
    /// </summary>
    [JsonPropertyName("input_file_id")]
    public required string InputFileId { get; init; }

    /// <summary>
    /// Time window for batch completion (optional)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("completion_window")]
    public string? CompletionWindow { get; init; }

    /// <summary>
    /// Priority for batch processing (optional)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priority")]
    public int? Priority { get; init; }

    /// <summary>
    /// Model to use for processing batch requests
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_id")]
    public string? ModelId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
