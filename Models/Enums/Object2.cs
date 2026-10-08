using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The object type, which is always video.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Object2>))]
public sealed record Object2 : OpenStringEnum<Object2>
{
    private Object2(string value) : base(value)
    {
    }

    public static readonly Object2 Video = new("video");

    public TResult Match<TResult>(Func<TResult> onVideo, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Video => onVideo(),
            _ => otherwise(Value)
        };

    public void Match(Action onVideo, Action<string> otherwise)
    {
        if (this == Video) onVideo();
        else otherwise(Value);
    }
}
