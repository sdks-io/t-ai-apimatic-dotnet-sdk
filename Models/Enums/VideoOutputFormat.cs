using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<VideoOutputFormat>))]
public sealed record VideoOutputFormat : OpenStringEnum<VideoOutputFormat>
{
    private VideoOutputFormat(string value) : base(value)
    {
    }

    public static readonly VideoOutputFormat Mp4 = new("MP4");

    public static readonly VideoOutputFormat Webm = new("WEBM");

    public TResult Match<TResult>(Func<TResult> onMp4, Func<TResult> onWebm, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Mp4 => onMp4(),
            _ when this == Webm => onWebm(),
            _ => otherwise(Value)
        };

    public void Match(Action onMp4, Action onWebm, Action<string> otherwise)
    {
        if (this == Mp4) onMp4();
        else if (this == Webm) onWebm();
        else otherwise(Value);
    }
}
