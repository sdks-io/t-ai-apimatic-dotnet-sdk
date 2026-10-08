using System;
using System.Collections.Generic;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.EndpointService;

/// <summary>
/// The inputs of the EndpointServiceListEndpointEvents operation.
/// </summary>
public sealed record EndpointServiceListEndpointEventsRequest
{
    public required string ProjectId { get; init; }

    public required string Id { get; init; }

    public int? Limit { get; init; }

    public string? After { get; init; }

    public IReadOnlyList<string>? Types { get; init; }

    public MinLevel? MinLevel { get; init; }

    public DateTimeOffset? Since { get; init; }

    public DateTimeOffset? Until { get; init; }

    public IReadOnlyList<string>? DeploymentIds { get; init; }

    public IReadOnlyList<SourceKind1>? SourceKinds { get; init; }

    public string? SubjectId { get; init; }
}
