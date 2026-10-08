using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Current status and metadata for a queued job.
/// </summary>
public record QueueJobStatusResponse
{
    /// <summary>
    /// Timestamp when a worker claimed the job
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("claimed_at")]
    public DateTimeOffset? ClaimedAt { get; init; }

    /// <summary>
    /// Timestamp when the job was created
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; init; }

    /// <summary>
    /// Timestamp when the job completed (done or failed)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("done_at")]
    public DateTimeOffset? DoneAt { get; init; }

    /// <summary>
    /// Job metadata. Contains keys from the submit request, plus any
    /// modifications from the model or system (e.g. progress, retry
    /// history).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("info")]
    public object? Info { get; init; }

    /// <summary>
    /// Freeform model input, as submitted
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inputs")]
    public object? Inputs { get; init; }

    /// <summary>
    /// Model identifier the job was submitted to
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Freeform model output, populated when the job reaches done status. Contents are model-specific.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outputs")]
    public object? Outputs { get; init; }

    /// <summary>
    /// Job priority. Higher values are processed first.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priority")]
    public int? Priority { get; init; }

    /// <summary>
    /// The request ID that was returned from the submit endpoint
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    /// <summary>
    /// Number of times this job has been retried. Workers set a claim
    /// timeout and must send periodic status updates to keep the job alive.
    /// If no update is received within the timeout, the job is returned to
    /// the queue and retried. After 3 retries the job is permanently
    /// failed. Jobs explicitly failed by the model are not retried.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("retries")]
    public int? Retries { get; init; }

    /// <summary>
    /// Current job status. Transitions: pending → running → done/failed. A pending job may also be canceled.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status10 Status { get; init; }

    /// <summary>
    /// Non-fatal messages about the request (e.g. deprecation notices)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<string>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
