using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// How strictly the regions list is enforced.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Constraint>))]
public sealed record Constraint : OpenStringEnum<Constraint>
{
    private Constraint(string value) : base(value)
    {
    }

    public static readonly Constraint EnforcementRequired = new("ENFORCEMENT_REQUIRED");

    public static readonly Constraint EnforcementPreferred = new("ENFORCEMENT_PREFERRED");

    public TResult Match<TResult>(Func<TResult> onEnforcementRequired,
        Func<TResult> onEnforcementPreferred,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == EnforcementRequired => onEnforcementRequired(),
            _ when this == EnforcementPreferred => onEnforcementPreferred(),
            _ => otherwise(Value)
        };

    public void Match(Action onEnforcementRequired, Action onEnforcementPreferred, Action<string> otherwise)
    {
        if (this == EnforcementRequired) onEnforcementRequired();
        else if (this == EnforcementPreferred) onEnforcementPreferred();
        else otherwise(Value);
    }
}
