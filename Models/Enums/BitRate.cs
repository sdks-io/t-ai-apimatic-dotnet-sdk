using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Bitrate of the MP3 audio output in bits per second. Only applicable when response_format is mp3. Higher values produce better audio quality at larger file sizes. Default is 128000. Currently supported on Cartesia models.
/// </summary>
[JsonConverter(typeof(IntEnumConverter<BitRate>))]
public sealed record BitRate : OpenIntEnum<BitRate>
{
    private BitRate(long value) : base(value)
    {
    }

    public static readonly BitRate Value32000 = new(32000L);

    public static readonly BitRate Value64000 = new(64000L);

    public static readonly BitRate Value96000 = new(96000L);

    public static readonly BitRate Value128000 = new(128000L);

    public static readonly BitRate Value192000 = new(192000L);

    public TResult Match<TResult>(Func<TResult> onValue32000,
        Func<TResult> onValue64000,
        Func<TResult> onValue96000,
        Func<TResult> onValue128000,
        Func<TResult> onValue192000,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value32000 => onValue32000(),
            _ when this == Value64000 => onValue64000(),
            _ when this == Value96000 => onValue96000(),
            _ when this == Value128000 => onValue128000(),
            _ when this == Value192000 => onValue192000(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue32000,
        Action onValue64000,
        Action onValue96000,
        Action onValue128000,
        Action onValue192000,
        Action<long> otherwise)
    {
        if (this == Value32000) onValue32000();
        else if (this == Value64000) onValue64000();
        else if (this == Value96000) onValue96000();
        else if (this == Value128000) onValue128000();
        else if (this == Value192000) onValue192000();
        else otherwise(Value);
    }
}
