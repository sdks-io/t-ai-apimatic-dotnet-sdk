using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Object type. Always <c>list</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ObjectEnum>))]
public sealed record ObjectEnum : OpenStringEnum<ObjectEnum>
{
    private ObjectEnum(string value) : base(value)
    {
    }

    public static readonly ObjectEnum List = new("list");

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
