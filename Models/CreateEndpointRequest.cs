using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record CreateEndpointRequest
{
    /// <summary>
    /// A human-readable name for the endpoint
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }

    /// <summary>
    /// The model to deploy on this endpoint
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// The hardware configuration to use for this endpoint
    /// </summary>
    [JsonPropertyName("hardware")]
    public required string Hardware { get; init; }

    /// <summary>
    /// Configuration for automatic scaling of the endpoint
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public required Autoscaling1 Autoscaling { get; init; }

    /// <summary>
    /// This parameter is deprecated and no longer has any effect.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disable_prompt_cache")]
    public bool? DisablePromptCache { get; init; } = false;

    /// <summary>
    /// Whether to disable speculative decoding for this endpoint
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disable_speculative_decoding")]
    public bool? DisableSpeculativeDecoding { get; init; } = false;

    /// <summary>
    /// The desired state of the endpoint
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public State7? State { get; init; } = State7.Started;

    /// <summary>
    /// The number of minutes of inactivity after which the endpoint stops automatically. Set to null, omit, or set to 0 to disable automatic timeout.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactive_timeout")]
    public int? InactiveTimeout { get; init; }

    /// <summary>
    /// Create the endpoint in a specified availability zone (e.g., us-central-4b)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("availability_zone")]
    public string? AvailabilityZone { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
