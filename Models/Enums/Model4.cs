using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Model to use for translation
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Model4>))]
public sealed record Model4 : OpenStringEnum<Model4>
{
    private Model4(string value) : base(value)
    {
    }

    public static readonly Model4 OpenaiWhisperLargeV3 = new("openai/whisper-large-v3");

    public TResult Match<TResult>(Func<TResult> onOpenaiWhisperLargeV3, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OpenaiWhisperLargeV3 => onOpenaiWhisperLargeV3(),
            _ => otherwise(Value)
        };

    public void Match(Action onOpenaiWhisperLargeV3, Action<string> otherwise)
    {
        if (this == OpenaiWhisperLargeV3) onOpenaiWhisperLargeV3();
        else otherwise(Value);
    }
}
