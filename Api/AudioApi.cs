using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TogetherApIs.Core;
using TogetherApIs.Core.ErrorResponse;
using TogetherApIs.Core.Exceptions;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Request;
using TogetherApIs.Core.Response;
using TogetherApIs.Errors;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Requests.AudioApi;

namespace TogetherApIs.Api;

public sealed class AudioApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AudioApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create audio generation request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BinaryContent"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AudioSpeechError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generate audio from input text
    /// </remarks>
    public Task<BinaryContent> AudioSpeech(AudioSpeechOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/audio/speech"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            BinaryResponse.Instance,
            AudioSpeechError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create audio transcription request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AudioTranscriptionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AudioTranscriptionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Transcribes audio into text
    /// </remarks>
    public Task<AudioTranscriptionResponse> AudioTranscriptions(AudioTranscriptionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/audio/transcriptions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("file", request.File),
                new MultipartParam("model", request.Model),
                new MultipartParam("language", request.Language),
                new MultipartParam("prompt", request.Prompt),
                new MultipartParam("response_format", request.ResponseFormat),
                new MultipartParam("temperature", request.Temperature),
                new MultipartParam("timestamp_granularities", request.TimestampGranularities),
                new MultipartParam("diarize", request.Diarize),
                new MultipartParam("min_speakers", request.MinSpeakers),
                new MultipartParam("max_speakers", request.MaxSpeakers)),
            JsonResponse.Create<AudioTranscriptionResponse>(),
            AudioTranscriptionsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create audio translation request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AudioTranslationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AudioTranslationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Translates audio into English
    /// </remarks>
    public Task<AudioTranslationResponse> AudioTranslations(AudioTranslationsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/audio/translations"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormRequest.Create(
                new MultipartParam("file", request.File),
                new MultipartParam("model", request.Model),
                new MultipartParam("language", request.Language),
                new MultipartParam("prompt", request.Prompt),
                new MultipartParam("response_format", request.ResponseFormat),
                new MultipartParam("temperature", request.Temperature),
                new MultipartParam("timestamp_granularities", request.TimestampGranularities)),
            JsonResponse.Create<AudioTranslationResponse>(),
            AudioTranslationsError.Response,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Real-time audio transcription via WebSocket
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Establishes a WebSocket connection for real-time audio transcription. This endpoint uses WebSocket protocol (wss://api.together.ai/v1/realtime) for bidirectional streaming communication.
    /// <para>
    /// <b>Connection Setup:</b>
    /// - Protocol: WebSocket (wss://)
    /// - Authentication: Pass API key as Bearer token in Authorization header
    /// - Parameters: Sent as query parameters (model, input_audio_format)
    /// </para>
    /// <para>
    /// <b>Client Events:</b>
    /// - <c>input_audio_buffer.append</c>: Send audio chunks as base64-encoded data
    ///   ```json
    ///   {
    ///     "type": "input_audio_buffer.append",
    ///     "audio": "&lt;base64_encoded_audio_chunk&gt;"
    ///   }
    ///   ```
    /// - <c>input_audio_buffer.commit</c>: Signal end of audio stream. When VAD is enabled, the server automatically detects speech boundaries and emits <c>completed</c> events. When VAD is disabled, you must send <c>commit</c> to trigger transcription of the buffered audio.
    ///   ```json
    ///   {
    ///     "type": "input_audio_buffer.commit"
    ///   }
    ///   ```
    /// - <c>transcription_session.updated</c>: Update session configuration, including Voice Activity Detection (VAD) parameters. Send this after receiving <c>session.created</c>. Can also be sent at any time during the session to change VAD settings.
    ///   ```json
    ///   {
    ///     "type": "transcription_session.updated",
    ///     "session": {
    ///       "turn_detection": {
    ///         "type": "server_vad",
    ///         "threshold": 0.3,
    ///         "min_silence_duration_ms": 500,
    ///         "min_speech_duration_ms": 250,
    ///         "max_speech_duration_s": 5.0,
    ///         "speech_pad_ms": 250
    ///       }
    ///     }
    ///   }
    ///   ```
    ///   To disable VAD entirely (manual commit mode), set <c>turn_detection</c> to <c>null</c>:
    ///   ```json
    ///   {
    ///     "type": "transcription_session.updated",
    ///     "session": {
    ///       "turn_detection": null
    ///     }
    ///   }
    ///   ```
    /// </para>
    /// <para>
    /// <b>Voice Activity Detection (VAD)</b>
    /// </para>
    /// <para>
    /// VAD controls how the server automatically detects speech segments in the audio stream. When enabled (the default), the server uses Silero VAD to identify speech regions and emits transcription events as each segment completes. When disabled, you must manually call <c>input_audio_buffer.commit</c> to trigger transcription.
    /// </para>
    /// <para>
    /// VAD can be configured in two ways:
    /// 1. <b>Query parameters</b> at connection time: <c>turn_detection=server_vad&amp;threshold=0.3&amp;min_silence_duration_ms=500</c>
    /// 2. <b>Session message</b> after connection: Send <c>transcription_session.updated</c> with a <c>turn_detection</c> object (see above)
    /// </para>
    /// <para>
    /// To disable VAD at connection time, use <c>turn_detection=none</c> as a query parameter.
    /// </para>
    /// <para>
    /// <b>VAD Parameters:</b>
    /// </para>
    /// <para>
    /// All parameters are Omitted fields use their defaults.
    /// </para>
    /// <para>
    /// | Parameter | Type | Default | Description |
    /// |-----------|------|---------|-------------|
    /// | <c>type</c> | string | <c>server_vad</c> | VAD mode. Use <c>server_vad</c> to enable, or set <c>turn_detection</c> to <c>null</c> to disable. |
    /// | <c>threshold</c> | float | <c>0.3</c> | Speech probability threshold (0.0–1.0). Audio frames with probability above this value are classified as speech. Lower values detect more speech but may increase false positives. For low-SNR audio (e.g., 8kHz phone calls), values of 0.01–0.2 may work better. |
    /// | <c>min_silence_duration_ms</c> | int | <c>500</c> | Minimum silence duration in milliseconds before ending a speech segment. Higher values merge nearby speech bursts into single segments. For phone calls with mid-sentence pauses, 2000–5000ms prevents over-segmentation. |
    /// | <c>min_speech_duration_ms</c> | int | <c>250</c> | Minimum speech segment duration in milliseconds. Segments shorter than this are discarded. Filters out brief noise bursts or clicks. |
    /// | <c>max_speech_duration_s</c> | float | <c>5.0</c> | Maximum speech segment duration in seconds. Segments longer than this are force-split at the longest internal silence gap. Useful for continuous speech without natural pauses. |
    /// | <c>speech_pad_ms</c> | int | <c>250</c> | Padding in milliseconds added to the start and end of each detected segment. Prevents clipping speech edges. When padding would cause adjacent segments to overlap, the gap is split at the midpoint instead. |
    /// </para>
    /// <para>
    /// <b>Server Events:</b>
    /// - <c>session.created</c>: Initial session confirmation (sent first)
    ///   ```json
    ///   {
    ///     "type": "session.created",
    ///     "session": {
    ///       "id": "session-id",
    ///       "object": "realtime.session",
    ///       "modalities": ["audio"],
    ///       "model": "openai/whisper-large-v3"
    ///     }
    ///   }
    ///   ```
    /// - <c>transcription_session.updated</c>: Confirms session configuration was applied. Sent in response to a client <c>transcription_session.updated</c> message.
    ///   ```json
    ///   {
    ///     "type": "transcription_session.updated",
    ///     "session": {
    ///       "turn_detection": {
    ///         "type": "server_vad",
    ///         "threshold": 0.3,
    ///         "min_silence_duration_ms": 500,
    ///         "min_speech_duration_ms": 250,
    ///         "max_speech_duration_s": 5.0,
    ///         "speech_pad_ms": 250
    ///       }
    ///     }
    ///   }
    ///   ```
    /// - <c>conversation.item.input_audio_transcription.delta</c>: Partial transcription results
    ///   ```json
    ///   {
    ///     "type": "conversation.item.input_audio_transcription.delta",
    ///     "delta": "The quick brown"
    ///   }
    ///   ```
    /// - <c>conversation.item.input_audio_transcription.completed</c>: Final transcription
    ///   ```json
    ///   {
    ///     "type": "conversation.item.input_audio_transcription.completed",
    ///     "transcript": "The quick brown fox jumps over the lazy dog"
    ///   }
    ///   ```
    /// - <c>conversation.item.input_audio_transcription.failed</c>: Error occurred
    ///   ```json
    ///   {
    ///     "type": "conversation.item.input_audio_transcription.failed",
    ///     "error": {
    ///       "message": "Error description",
    ///       "type": "invalid_request_error",
    ///       "param": null,
    ///       "code": "invalid_api_key"
    ///     }
    ///   }
    ///   ```
    /// </para>
    /// <para>
    /// <b>Error Codes:</b>
    /// - <c>invalid_api_key</c>: Invalid API key provided (401)
    /// - <c>missing_api_key</c>: Authorization header missing (401)
    /// - <c>model_not_available</c>: Invalid or unavailable model (400)
    /// - Unsupported audio format errors (400)
    /// </para>
    /// </remarks>
    public Task RealtimeTranscription(RealtimeTranscriptionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/realtime"),
            [],
            [new Param("model", request.Model), new Param("input_audio_format", request.InputAudioFormat)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Real-time text-to-speech via WebSocket
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Establishes a WebSocket connection for real-time text-to-speech generation. This endpoint uses WebSocket protocol (wss://api.together.ai/v1/audio/speech/websocket) for bidirectional streaming communication.
    /// <para>
    /// <b>Connection Setup:</b>
    /// - Protocol: WebSocket (wss://)
    /// - Authentication: Pass API key as Bearer token in Authorization header
    /// - Parameters: Sent as query parameters (model, voice, max_partial_length, language)
    /// </para>
    /// <para>
    /// <b>Client Events:</b>
    /// - <c>tts_session.updated</c>: Update session parameters like voice. The <c>session</c> object also accepts an <c>extra_params</c> field for additional model-specific parameters that fine-tune speech generation behavior, such as <c>pronunciation_dict</c> (a list of pronunciation rules for specific characters or symbols, where each entry uses the format <c>"&lt;source&gt;/&lt;replacement&gt;"</c> (e.g., <c>["omg/oh my god"]</c>) to override how the model pronounces matching tokens).
    ///   ```json
    ///   {
    ///     "type": "tts_session.updated",
    ///     "session": {
    ///       "voice": "tara",
    ///       "extra_params": {
    ///         "pronunciation_dict": ["omg/oh my god"]
    ///       }
    ///     }
    ///   }
    ///   ```
    /// - <c>input_text_buffer.append</c>: Send text chunks for TTS generation
    ///   ```json
    ///   {
    ///     "type": "input_text_buffer.append",
    ///     "text": "Hello, this is a test."
    ///   }
    ///   ```
    /// - <c>input_text_buffer.clear</c>: Clear the buffered text
    ///   ```json
    ///   {
    ///     "type": "input_text_buffer.clear"
    ///   }
    ///   ```
    /// - <c>input_text_buffer.commit</c>: Signal end of text input and process remaining text
    ///   ```json
    ///   {
    ///     "type": "input_text_buffer.commit"
    ///   }
    ///   ```
    /// </para>
    /// <para>
    /// <b>Server Events:</b>
    /// - <c>session.created</c>: Initial session confirmation (sent first)
    ///   ```json
    ///   {
    ///     "event_id": "evt_123456",
    ///     "type": "session.created",
    ///     "session": {
    ///       "id": "session-id",
    ///       "object": "realtime.tts.session",
    ///       "modalities": ["text", "audio"],
    ///       "model": "hexgrad/Kokoro-82M",
    ///       "voice": "tara"
    ///     }
    ///   }
    ///   ```
    /// - <c>conversation.item.input_text.received</c>: Acknowledgment that text was received
    ///   ```json
    ///   {
    ///     "type": "conversation.item.input_text.received",
    ///     "text": "Hello, this is a test."
    ///   }
    ///   ```
    /// - <c>conversation.item.audio_output.delta</c>: Audio chunks as base64-encoded data
    ///   ```json
    ///   {
    ///     "type": "conversation.item.audio_output.delta",
    ///     "item_id": "tts_1",
    ///     "delta": "&lt;base64_encoded_audio_chunk&gt;"
    ///   }
    ///   ```
    /// - <c>conversation.item.audio_output.done</c>: Audio generation complete for an item
    ///   ```json
    ///   {
    ///     "type": "conversation.item.audio_output.done",
    ///     "item_id": "tts_1"
    ///   }
    ///   ```
    /// - <c>conversation.item.tts.failed</c>: Error occurred
    ///   ```json
    ///   {
    ///     "type": "conversation.item.tts.failed",
    ///     "error": {
    ///       "message": "Error description",
    ///       "type": "invalid_request_error",
    ///       "param": null,
    ///       "code": "invalid_api_key"
    ///     }
    ///   }
    ///   ```
    /// </para>
    /// <para>
    /// <b>Text Processing:</b>
    /// - Partial text (no sentence ending) is held in buffer until:
    ///   - We believe that the text is complete enough to be processed for TTS generation
    ///   - The partial text exceeds <c>max_partial_length</c> characters (default: 250)
    ///   - The <c>input_text_buffer.commit</c> event is received
    /// </para>
    /// <para>
    /// <b>Audio Format:</b>
    /// - Format: Raw PCM (s16le, mono)
    /// - Sample Rate: 24000 Hz
    /// - Encoding: Base64 (per delta event)
    /// - Delivered via <c>conversation.item.audio_output.delta</c> events
    /// </para>
    /// <para>
    /// <b>Error Codes:</b>
    /// - <c>invalid_api_key</c>: Invalid API key provided (401)
    /// - <c>missing_api_key</c>: Authorization header missing (401)
    /// - <c>model_not_available</c>: Invalid or unavailable model (400)
    /// - Invalid text format errors (400)
    /// </para>
    /// </remarks>
    public Task RealtimeTts(RealtimeTtsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/audio/speech/websocket"),
            [],
            [
                new Param("model", request.Model),
                new Param("voice", request.Voice),
                new Param("max_partial_length", request.MaxPartialLength),
                new Param("language", request.Language),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.BearerAuth],
            requestOptions,
            cancellationToken);
}
