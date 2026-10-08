using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// The learning rate scheduler to use. It specifies how the learning rate is adjusted during training.
/// </summary>
public record LrScheduler2
{
    [JsonPropertyName("lr_scheduler_type")]
    public required LrSchedulerType LrSchedulerType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lr_scheduler_args")]
    public LrSchedulerArgs? LrSchedulerArgs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
