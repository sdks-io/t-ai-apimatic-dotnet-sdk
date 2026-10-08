using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

/// <summary>
/// Saved inference checkpoint
/// </summary>
public record RlInferenceCheckpoint
{
    /// <summary>
    /// Unique identifier for the checkpoint
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Training step at time of save
    /// </summary>
    [JsonPropertyName("step")]
    public required Step1 Step { get; init; }

    /// <summary>
    /// Timestamp when the checkpoint was created
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Model registration details
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("registration")]
    public RlInferenceCheckpointRegistration2? Registration { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
