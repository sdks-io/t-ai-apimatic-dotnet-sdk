using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The format of audio output. Supported formats are mp3, wav, raw if streaming is false. If streaming is true, the only supported format is raw.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResponseFormat>))]
public sealed record ResponseFormat : OpenStringEnum<ResponseFormat>
{
    private ResponseFormat(string value) : base(value)
    {
    }

    public static readonly ResponseFormat Mp3 = new("mp3");

    public static readonly ResponseFormat Wav = new("wav");

    public static readonly ResponseFormat Raw = new("raw");

    public TResult Match<TResult>(Func<TResult> onMp3,
        Func<TResult> onWav,
        Func<TResult> onRaw,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Mp3 => onMp3(),
            _ when this == Wav => onWav(),
            _ when this == Raw => onRaw(),
            _ => otherwise(Value)
        };

    public void Match(Action onMp3, Action onWav, Action onRaw, Action<string> otherwise)
    {
        if (this == Mp3) onMp3();
        else if (this == Wav) onWav();
        else if (this == Raw) onRaw();
        else otherwise(Value);
    }
}
