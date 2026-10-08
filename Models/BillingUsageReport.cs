using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record BillingUsageReport
{
    [JsonPropertyName("object")]
    public string Object { get; } = "list";

    /// <summary>
    /// ID of the organization the report belongs to.
    /// </summary>
    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; init; }

    /// <summary>
    /// Billing month (YYYY-MM).
    /// </summary>
    [JsonPropertyName("billing_period")]
    public required string BillingPeriod { get; init; }

    /// <summary>
    /// Start of the earliest time window with usage in the month (UTC, ISO 8601); null when the month has no usage.
    /// </summary>
    [JsonPropertyName("earliest_window_start")]
    public required DateTimeOffset? EarliestWindowStart { get; init; }

    /// <summary>
    /// Exclusive end of the latest time window with usage in the month (UTC, ISO 8601); null when the month has no usage. Describes the whole month, not the current page.
    /// </summary>
    [JsonPropertyName("latest_window_end")]
    public required DateTimeOffset? LatestWindowEnd { get; init; }

    [JsonPropertyName("currency")]
    public string Currency { get; } = "USD";

    /// <summary>
    /// Time windows containing usage line items.
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<BillingUsageWindow> Data { get; init; }

    /// <summary>
    /// Opaque cursor for the next page; null when this is the last page.
    /// </summary>
    [JsonPropertyName("next_cursor")]
    public required string? NextCursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
