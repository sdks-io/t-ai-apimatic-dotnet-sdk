using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Filter endpoints by type
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type18>))]
public sealed record Type18 : OpenStringEnum<Type18>
{
    private Type18(string value) : base(value)
    {
    }

    public static readonly Type18 Dedicated = new("dedicated");

    public static readonly Type18 Serverless = new("serverless");

    public TResult Match<TResult>(Func<TResult> onDedicated,
        Func<TResult> onServerless,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Dedicated => onDedicated(),
            _ when this == Serverless => onServerless(),
            _ => otherwise(Value)
        };

    public void Match(Action onDedicated, Action onServerless, Action<string> otherwise)
    {
        if (this == Dedicated) onDedicated();
        else if (this == Serverless) onServerless();
        else otherwise(Value);
    }
}
