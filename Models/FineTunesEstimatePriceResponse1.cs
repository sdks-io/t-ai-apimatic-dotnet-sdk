using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record FineTunesEstimatePriceResponse1
{
    /// <summary>
    /// Whether price estimation is available for the requested fine-tune job.
    /// </summary>
    [JsonPropertyName("estimation_available")]
    public string EstimationAvailable { get; } = "False";

    /// <summary>
    /// Reason price estimation is unavailable for the requested fine-tune job.
    /// </summary>
    [JsonPropertyName("unavailable_reason")]
    public required UnavailableReason UnavailableReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
