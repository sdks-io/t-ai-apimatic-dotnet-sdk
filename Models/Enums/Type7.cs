using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The type of endpoint
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type7>))]
public sealed record Type7 : OpenStringEnum<Type7>
{
    private Type7(string value) : base(value)
    {
    }

    public static readonly Type7 Serverless = new("serverless");

    public static readonly Type7 Dedicated = new("dedicated");

    public TResult Match<TResult>(Func<TResult> onServerless,
        Func<TResult> onDedicated,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Serverless => onServerless(),
            _ when this == Dedicated => onDedicated(),
            _ => otherwise(Value)
        };

    public void Match(Action onServerless, Action onDedicated, Action<string> otherwise)
    {
        if (this == Serverless) onServerless();
        else if (this == Dedicated) onDedicated();
        else otherwise(Value);
    }
}
