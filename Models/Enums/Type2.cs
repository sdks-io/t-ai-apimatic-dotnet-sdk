using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Informational condition type. <c>CapacityLimited</c> means the current step advanced partially because full capacity was not placeable.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type2>))]
public sealed record Type2 : OpenStringEnum<Type2>
{
    private Type2(string value) : base(value)
    {
    }

    public static readonly Type2 CapacityLimited = new("CapacityLimited");

    public TResult Match<TResult>(Func<TResult> onCapacityLimited, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CapacityLimited => onCapacityLimited(),
            _ => otherwise(Value)
        };

    public void Match(Action onCapacityLimited, Action<string> otherwise)
    {
        if (this == CapacityLimited) onCapacityLimited();
        else otherwise(Value);
    }
}
