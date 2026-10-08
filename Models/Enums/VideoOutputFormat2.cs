using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Specifies the format of the output video. Defaults to MP4.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VideoOutputFormat2>))]
public sealed record VideoOutputFormat2 : OpenStringEnum<VideoOutputFormat2>
{
    private VideoOutputFormat2(string value) : base(value)
    {
    }

    public static readonly VideoOutputFormat2 Mp4 = new("MP4");

    public static readonly VideoOutputFormat2 Webm = new("WEBM");

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
