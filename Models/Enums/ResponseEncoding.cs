using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Audio encoding of response. Only applicable when response_format is raw or pcm. Cartesia models respect this parameter and support all values. Orpheus, Kokoro, and Minimax models always return pcm_s16le regardless of this setting.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResponseEncoding>))]
public sealed record ResponseEncoding : OpenStringEnum<ResponseEncoding>
{
    private ResponseEncoding(string value) : base(value)
    {
    }

    public static readonly ResponseEncoding PcmF32Le = new("pcm_f32le");

    public static readonly ResponseEncoding PcmS16Le = new("pcm_s16le");

    public static readonly ResponseEncoding PcmMulaw = new("pcm_mulaw");

    public static readonly ResponseEncoding PcmAlaw = new("pcm_alaw");

    public TResult Match<TResult>(Func<TResult> onPcmF32Le,
        Func<TResult> onPcmS16Le,
        Func<TResult> onPcmMulaw,
        Func<TResult> onPcmAlaw,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PcmF32Le => onPcmF32Le(),
            _ when this == PcmS16Le => onPcmS16Le(),
            _ when this == PcmMulaw => onPcmMulaw(),
            _ when this == PcmAlaw => onPcmAlaw(),
            _ => otherwise(Value)
        };

    public void Match(Action onPcmF32Le,
        Action onPcmS16Le,
        Action onPcmMulaw,
        Action onPcmAlaw,
        Action<string> otherwise)
    {
        if (this == PcmF32Le) onPcmF32Le();
        else if (this == PcmS16Le) onPcmS16Le();
        else if (this == PcmMulaw) onPcmMulaw();
        else if (this == PcmAlaw) onPcmAlaw();
        else otherwise(Value);
    }
}
