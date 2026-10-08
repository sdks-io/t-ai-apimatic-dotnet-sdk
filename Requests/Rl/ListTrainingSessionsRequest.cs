using System.Collections.Generic;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the ListTrainingSessions operation.
/// </summary>
public sealed record ListTrainingSessionsRequest
{
    public IReadOnlyList<Status13>? Status { get; init; }

    public int Limit { get; init; } = 20;

    public string? After { get; init; }

    public string? ModelResourcesId { get; init; }

    public string? CreatedBy { get; init; }
}
