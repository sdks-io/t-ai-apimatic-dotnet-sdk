using TogetherApIs.Models;

namespace TogetherApIs.Requests.AudioApi;

/// <summary>
/// The inputs of the AudioSpeech operation.
/// </summary>
public sealed record AudioSpeechOperationRequest
{
    public AudioSpeechRequest? Body { get; init; }
}
