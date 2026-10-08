using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.AudioApi;

/// <summary>
/// The inputs of the RealtimeTranscription operation.
/// </summary>
public sealed record RealtimeTranscriptionRequest
{
    public required string Model { get; init; }

    /// <summary>
    /// Audio format specification. Currently supports 16-bit PCM at 16kHz sample rate.
    /// </summary>
    public InputAudioFormat InputAudioFormat { get; init; } = InputAudioFormat.PcmS16Le16000;
}
