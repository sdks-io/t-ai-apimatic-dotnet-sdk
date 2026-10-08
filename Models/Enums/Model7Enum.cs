using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The TTS model to use for speech generation. Can also be set via <c>tts_session.updated</c> event.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Model7Enum>))]
public sealed record Model7Enum : OpenStringEnum<Model7Enum>
{
    private Model7Enum(string value) : base(value)
    {
    }

    public static readonly Model7Enum HexgradKokoro82M = new("hexgrad/Kokoro-82M");

    public static readonly Model7Enum CartesiaSonicEnglish = new("cartesia/sonic-english");

    public TResult Match<TResult>(Func<TResult> onHexgradKokoro82M,
        Func<TResult> onCartesiaSonicEnglish,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == HexgradKokoro82M => onHexgradKokoro82M(),
            _ when this == CartesiaSonicEnglish => onCartesiaSonicEnglish(),
            _ => otherwise(Value)
        };

    public void Match(Action onHexgradKokoro82M, Action onCartesiaSonicEnglish, Action<string> otherwise)
    {
        if (this == HexgradKokoro82M) onHexgradKokoro82M();
        else if (this == CartesiaSonicEnglish) onCartesiaSonicEnglish();
        else otherwise(Value);
    }
}
