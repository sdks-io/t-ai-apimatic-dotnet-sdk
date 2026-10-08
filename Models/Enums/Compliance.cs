using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Compliance>))]
public sealed record Compliance : OpenStringEnum<Compliance>
{
    private Compliance(string value) : base(value)
    {
    }

    public static readonly Compliance Hipaa = new("hipaa");

    public TResult Match<TResult>(Func<TResult> onHipaa, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Hipaa => onHipaa(),
            _ => otherwise(Value)
        };

    public void Match(Action onHipaa, Action<string> otherwise)
    {
        if (this == Hipaa) onHipaa();
        else otherwise(Value);
    }
}
