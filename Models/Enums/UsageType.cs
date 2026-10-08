using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Filter endpoints by usage type
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UsageType>))]
public sealed record UsageType : OpenStringEnum<UsageType>
{
    private UsageType(string value) : base(value)
    {
    }

    public static readonly UsageType OnDemand = new("on-demand");

    public static readonly UsageType Reserved = new("reserved");

    public TResult Match<TResult>(Func<TResult> onOnDemand,
        Func<TResult> onReserved,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OnDemand => onOnDemand(),
            _ when this == Reserved => onReserved(),
            _ => otherwise(Value)
        };

    public void Match(Action onOnDemand, Action onReserved, Action<string> otherwise)
    {
        if (this == OnDemand) onOnDemand();
        else if (this == Reserved) onReserved();
        else otherwise(Value);
    }
}
