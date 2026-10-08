using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<OutputModality>))]
public sealed record OutputModality : OpenStringEnum<OutputModality>
{
    private OutputModality(string value) : base(value)
    {
    }

    public static readonly OutputModality ModalityText = new("MODALITY_TEXT");

    public static readonly OutputModality ModalityImage = new("MODALITY_IMAGE");

    public static readonly OutputModality ModalityAudio = new("MODALITY_AUDIO");

    public static readonly OutputModality ModalityVideo = new("MODALITY_VIDEO");

    public TResult Match<TResult>(Func<TResult> onModalityText,
        Func<TResult> onModalityImage,
        Func<TResult> onModalityAudio,
        Func<TResult> onModalityVideo,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ModalityText => onModalityText(),
            _ when this == ModalityImage => onModalityImage(),
            _ when this == ModalityAudio => onModalityAudio(),
            _ when this == ModalityVideo => onModalityVideo(),
            _ => otherwise(Value)
        };

    public void Match(Action onModalityText,
        Action onModalityImage,
        Action onModalityAudio,
        Action onModalityVideo,
        Action<string> otherwise)
    {
        if (this == ModalityText) onModalityText();
        else if (this == ModalityImage) onModalityImage();
        else if (this == ModalityAudio) onModalityAudio();
        else if (this == ModalityVideo) onModalityVideo();
        else otherwise(Value);
    }
}
