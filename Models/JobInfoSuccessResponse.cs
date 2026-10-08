using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record JobInfoSuccessResponse
{
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("job_id")]
    public required string JobId { get; init; }

    [JsonPropertyName("status")]
    public required Status4 Status { get; init; }

    [JsonPropertyName("status_updates")]
    public required IReadOnlyList<StatusUpdate> StatusUpdates { get; init; }

    [JsonPropertyName("args")]
    public required Args Args { get; init; }

    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    [JsonPropertyName("updated_at")]
    public required DateTimeOffset UpdatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
