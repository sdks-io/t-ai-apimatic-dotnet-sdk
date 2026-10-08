using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// The endpoint to use for batch processing. Each line of the uploaded input file is dispatched against this endpoint.
/// - <c>/v1/chat/completions</c> — chat completion batches
/// - <c>/v1/audio/transcriptions</c> — audio transcription batches (e.g. <c>openai/whisper-large-v3</c>)
/// - <c>/v1/audio/translations</c> — audio translation batches
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Endpoint>))]
public sealed record Endpoint : OpenStringEnum<Endpoint>
{
    private Endpoint(string value) : base(value)
    {
    }

    public static readonly Endpoint V1ChatCompletions = new("/v1/chat/completions");

    public static readonly Endpoint V1AudioTranscriptions = new("/v1/audio/transcriptions");

    public static readonly Endpoint V1AudioTranslations = new("/v1/audio/translations");

    public TResult Match<TResult>(Func<TResult> onV1ChatCompletions,
        Func<TResult> onV1AudioTranscriptions,
        Func<TResult> onV1AudioTranslations,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == V1ChatCompletions => onV1ChatCompletions(),
            _ when this == V1AudioTranscriptions => onV1AudioTranscriptions(),
            _ when this == V1AudioTranslations => onV1AudioTranslations(),
            _ => otherwise(Value)
        };

    public void Match(Action onV1ChatCompletions,
        Action onV1AudioTranscriptions,
        Action onV1AudioTranslations,
        Action<string> otherwise)
    {
        if (this == V1ChatCompletions) onV1ChatCompletions();
        else if (this == V1AudioTranscriptions) onV1AudioTranscriptions();
        else if (this == V1AudioTranslations) onV1AudioTranslations();
        else otherwise(Value);
    }
}
