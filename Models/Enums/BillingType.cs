using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// RESERVED billing types allow you to specify the duration of the cluster reservation via the duration_days field.
/// ON_DEMAND billing types will give you ownership of the cluster until you delete it.
/// SCHEDULED_CAPACITY billing types allow you to reserve capacity for a scheduled time window. You must specify the reservation_start_time and reservation_end_time with this request.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BillingType>))]
public sealed record BillingType : OpenStringEnum<BillingType>
{
    private BillingType(string value) : base(value)
    {
    }

    public static readonly BillingType Reserved = new("RESERVED");

    public static readonly BillingType OnDemand = new("ON_DEMAND");

    public static readonly BillingType ScheduledCapacity = new("SCHEDULED_CAPACITY");

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
