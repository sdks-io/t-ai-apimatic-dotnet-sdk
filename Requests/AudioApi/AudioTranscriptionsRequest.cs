using TogetherApIs.Core.Validation.Attributes;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.AudioApi;

/// <summary>
/// The inputs of the AudioTranscriptions operation.
/// </summary>
public sealed record AudioTranscriptionsRequest
{
    /// <summary>
    /// Audio file upload or public HTTP/HTTPS URL. Supported formats: .wav, .mp3, .m4a, .webm, .flac, .ogg, .opus, .aac. Maximum duration 4 hours; longer audio is rejected with <c>audio_too_long</c>. Binary uploads are additionally capped at 80 MB (HTTP 413); URL-fetched audio is capped at 1 GB.
    /// </summary>
    public required File1 File { get; init; }

    /// <summary>
    /// Model to use for transcription
    /// </summary>
    public Model3 Model { get; init; } = Model3.OpenaiWhisperLargeV3;

    /// <summary>
    /// Optional ISO 639-1 language code. If <c>auto</c> is provided, language is auto-detected.
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

    /// <summary>
    /// Whether to enable speaker diarization. When enabled, you will get the speaker id for each word in the transcription. In the response, in the words array, you will get the speaker id for each word. In addition, we also return the speaker_segments array which contains the speaker id for each speaker segment along with the start and end time of the segment along with all the words in the segment. &lt;br&gt; &lt;br&gt; For eg - ... "speaker_segments": [
    ///   "speaker_id": "SPEAKER_00",
    ///   "start": 0,
    ///   "end": 30.02,
    ///   "words": [
    ///     {
    ///       "id": 0,
    ///       "word": "Tijana",
    ///       "start": 0,
    ///       "end": 11.475,
    ///       "speaker_id": "SPEAKER_00"
    ///     },
    ///     ...
    /// </summary>
    public bool Diarize { get; init; } = false;

    /// <summary>
    /// Minimum number of speakers expected in the audio. Used to improve diarization accuracy when the approximate number of speakers is known.
    /// </summary>
    public int? MinSpeakers { get; init; }

    /// <summary>
    /// Maximum number of speakers expected in the audio. Used to improve diarization accuracy when the approximate number of speakers is known.
    /// </summary>
    public int? MaxSpeakers { get; init; }
}
