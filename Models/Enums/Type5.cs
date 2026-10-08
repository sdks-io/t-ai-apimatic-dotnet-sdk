using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type5>))]
public sealed record Type5 : OpenStringEnum<Type5>
{
    private Type5(string value) : base(value)
    {
    }

    public static readonly Type5 ImageUrl = new("image_url");

    public TResult Match<TResult>(Func<TResult> onImageUrl, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ImageUrl => onImageUrl(),
            _ => otherwise(Value)
        };

    public void Match(Action onImageUrl, Action<string> otherwise)
    {
        if (this == ImageUrl) onImageUrl();
        else otherwise(Value);
    }
}
