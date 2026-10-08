using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Async optimizer step operation
/// </summary>
public record RlOptimStepOperation
{
    /// <summary>
    /// Operation ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Operation status
    /// </summary>
    [JsonPropertyName("status")]
    public RlTrainingOperationStatus1 Status { get; init; } = RlTrainingOperationStatus1.TrainingOperationStatusUnspecified;

    /// <summary>
    /// Result on success
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("output")]
    public RlOptimStepResult2? Output { get; init; }

    /// <summary>
    /// Error details on failure
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public RlTrainingOperationError1? Error { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
