using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record Session
{
    [JsonPropertyName("execute_count")]
    public required int ExecuteCount { get; init; }

    [JsonPropertyName("expires_at")]
    public required DateTimeOffset ExpiresAt { get; init; }

    /// <summary>
    /// Session Identifier. Used to make follow-up calls.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("last_execute_at")]
    public required DateTimeOffset LastExecuteAt { get; init; }

    [JsonPropertyName("started_at")]
    public required DateTimeOffset StartedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
