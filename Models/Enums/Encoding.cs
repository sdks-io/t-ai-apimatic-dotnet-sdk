using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Encoding of the file content. Use <c>string</c> for text files such as code, and <c>base64</c> for binary files, such as images.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Encoding>))]
public sealed record Encoding : OpenStringEnum<Encoding>
{
    private Encoding(string value) : base(value)
    {
    }

    public static readonly Encoding String = new("string");

    public static readonly Encoding Base64 = new("base64");

    public TResult Match<TResult>(Func<TResult> onString, Func<TResult> onBase64, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == String => onString(),
            _ when this == Base64 => onBase64(),
            _ => otherwise(Value)
        };

    public void Match(Action onString, Action onBase64, Action<string> otherwise)
    {
        if (this == String) onString();
        else if (this == Base64) onBase64();
        else otherwise(Value);
    }
}
