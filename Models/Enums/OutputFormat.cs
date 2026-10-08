using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The format of the image response. Can be either be <c>jpeg</c> or <c>png</c>. Defaults to <c>jpeg</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OutputFormat>))]
public sealed record OutputFormat : OpenStringEnum<OutputFormat>
{
    private OutputFormat(string value) : base(value)
    {
    }

    public static readonly OutputFormat Jpeg = new("jpeg");

    public static readonly OutputFormat Png = new("png");

    public TResult Match<TResult>(Func<TResult> onJpeg, Func<TResult> onPng, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Jpeg => onJpeg(),
            _ when this == Png => onPng(),
            _ => otherwise(Value)
        };

    public void Match(Action onJpeg, Action onPng, Action<string> otherwise)
    {
        if (this == Jpeg) onJpeg();
        else if (this == Png) onPng();
        else otherwise(Value);
    }
}
