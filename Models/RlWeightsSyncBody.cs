using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Request body for publishing updated policy parameters for sampling.
/// </summary>
public record RlWeightsSyncBody
{
    /// <summary>
    /// How updated parameters are made available for sampling. See <c>WeightSyncType</c> for accepted values.
    /// </summary>
    [JsonPropertyName("weight_sync_type")]
    public required RlWeightSyncType2 WeightSyncType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
