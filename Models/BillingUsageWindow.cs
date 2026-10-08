using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record BillingUsageWindow
{
    /// <summary>
    /// Day this window covers (UTC, YYYY-MM-DD). Present for both granularities.
    /// </summary>
    [JsonPropertyName("date")]
    public required string Date { get; init; }

    /// <summary>
    /// Window start (UTC, ISO 8601). Start of the day (daily) or hour (hourly).
    /// </summary>
    [JsonPropertyName("start_time")]
    public required DateTimeOffset StartTime { get; init; }

    /// <summary>
    /// Window end (UTC, ISO 8601), exclusive. Start of the next day (daily) or hour (hourly).
    /// </summary>
    [JsonPropertyName("end_time")]
    public required DateTimeOffset EndTime { get; init; }

    /// <summary>
    /// Usage line items in this time window.
    /// </summary>
    [JsonPropertyName("line_items")]
    public required IReadOnlyList<BillingUsageLineItem> LineItems { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
