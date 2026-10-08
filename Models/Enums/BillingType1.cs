using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Billing type for the cluster (RESERVED, ON_DEMAND, or SCHEDULED_CAPACITY).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BillingType1>))]
public sealed record BillingType1 : OpenStringEnum<BillingType1>
{
    private BillingType1(string value) : base(value)
    {
    }

    public static readonly BillingType1 Reserved = new("RESERVED");

    public static readonly BillingType1 OnDemand = new("ON_DEMAND");

    public static readonly BillingType1 ScheduledCapacity = new("SCHEDULED_CAPACITY");

    public TResult Match<TResult>(Func<TResult> onReserved,
        Func<TResult> onOnDemand,
        Func<TResult> onScheduledCapacity,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Reserved => onReserved(),
            _ when this == OnDemand => onOnDemand(),
            _ when this == ScheduledCapacity => onScheduledCapacity(),
            _ => otherwise(Value)
        };

    public void Match(Action onReserved, Action onOnDemand, Action onScheduledCapacity, Action<string> otherwise)
    {
        if (this == Reserved) onReserved();
        else if (this == OnDemand) onOnDemand();
        else if (this == ScheduledCapacity) onScheduledCapacity();
        else otherwise(Value);
    }
}
