using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The object type, which is always <c>list</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Object4>))]
public sealed record Object4 : OpenStringEnum<Object4>
{
    private Object4(string value) : base(value)
    {
    }

    public static readonly Object4 List = new("list");

    public TResult Match<TResult>(Func<TResult> onList, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == List => onList(),
            _ => otherwise(Value)
        };

    public void Match(Action onList, Action<string> otherwise)
    {
        if (this == List) onList();
        else otherwise(Value);
    }
}
