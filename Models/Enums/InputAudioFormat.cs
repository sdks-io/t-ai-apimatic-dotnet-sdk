using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<InputAudioFormat>))]
public sealed record InputAudioFormat : OpenStringEnum<InputAudioFormat>
{
    private InputAudioFormat(string value) : base(value)
    {
    }

    public static readonly InputAudioFormat PcmS16Le16000 = new("pcm_s16le_16000");

    public TResult Match<TResult>(Func<TResult> onPcmS16Le16000, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PcmS16Le16000 => onPcmS16Le16000(),
            _ => otherwise(Value)
        };

    public void Match(Action onPcmS16Le16000, Action<string> otherwise)
    {
        if (this == PcmS16Le16000) onPcmS16Le16000();
        else otherwise(Value);
    }
}
