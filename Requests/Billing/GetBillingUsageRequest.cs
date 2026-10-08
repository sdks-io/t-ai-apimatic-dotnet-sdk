using System.ComponentModel.DataAnnotations;
using TogetherApIs.Core.Validation.Attributes;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.Billing;

/// <summary>
/// The inputs of the GetBillingUsage operation.
/// </summary>
public sealed record GetBillingUsageRequest
{
    [RegularExpression("^\\d{4}-(0[1-9]|1[0-2])$")]
    public string? Month { get; init; }

    [MinLength(1)]
    public string? OrganizationId { get; init; }

    public Granularity Granularity { get; init; } = Granularity.Day;

    [Minimum(1)]
    [Maximum(1000)]
    public int Limit { get; init; } = 100;

    public string? After { get; init; }
}
