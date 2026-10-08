using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record LrScheduler
{
    [JsonPropertyName("lr_scheduler_type")]
    public required LrSchedulerType LrSchedulerType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lr_scheduler_args")]
    public LrSchedulerArgs? LrSchedulerArgs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
