using TogetherApIs.Core.Validation.Attributes;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.AudioApi;

/// <summary>
/// The inputs of the AudioTranslations operation.
/// </summary>
public sealed record AudioTranslationsRequest
{
    /// <summary>
    /// Audio file upload or public HTTP/HTTPS URL. Supported formats: .wav, .mp3, .m4a, .webm, .flac, .ogg, .opus, .aac. Maximum duration 4 hours; longer audio is rejected with <c>audio_too_long</c>. Binary uploads are additionally capped at 80 MB (HTTP 413); URL-fetched audio is capped at 1 GB.
    /// </summary>
    public required File1 File { get; init; }

    /// <summary>
    /// Model to use for translation
    /// </summary>
    public Model4 Model { get; init; } = Model4.OpenaiWhisperLargeV3;

    /// <summary>
    /// Target output language. Optional ISO 639-1 language code. If omitted, language is set to English.
    /// </summary>
    public string Language { get; init; } = "en";

    /// <summary>
    /// Optional text to bias decoding. Supported only on Whisper-family models (e.g. <c>openai/whisper-large-v3</c>). Other STT models (e.g. <c>nvidia/parakeet-tdt-0.6b-v3</c>) accept the field for API compatibility but ignore it.
    /// </summary>
    public string? Prompt { get; init; }

    /// <summary>
    /// The format of the response
    /// </summary>
    public ResponseFormat1 ResponseFormat { get; init; } = ResponseFormat1.Json;

    /// <summary>
    /// Sampling temperature between 0.0 and 1.0
    /// </summary>
    [Minimum(0.0)]
    [Maximum(1.0)]
    public double Temperature { get; init; } = 0d;

    /// <summary>
    /// Controls level of timestamp detail in verbose_json. Only used when response_format is verbose_json. Can be a single granularity or an array to get multiple levels.
    /// </summary>
    public TimestampGranularities1? TimestampGranularities { get; init; }
}
