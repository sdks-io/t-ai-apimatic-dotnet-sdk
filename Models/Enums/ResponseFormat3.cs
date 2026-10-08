using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Format of the image response. Can be either a base64 string or a URL.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResponseFormat3>))]
public sealed record ResponseFormat3 : OpenStringEnum<ResponseFormat3>
{
    private ResponseFormat3(string value) : base(value)
    {
    }

    public static readonly ResponseFormat3 Base64 = new("base64");

    public static readonly ResponseFormat3 Url = new("url");

    public TResult Match<TResult>(Func<TResult> onBase64, Func<TResult> onUrl, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Base64 => onBase64(),
            _ when this == Url => onUrl(),
            _ => otherwise(Value)
        };

    public void Match(Action onBase64, Action onUrl, Action<string> otherwise)
    {
        if (this == Base64) onBase64();
        else if (this == Url) onUrl();
        else otherwise(Value);
    }
}
