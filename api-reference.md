# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [TogetherApIsClient](TogetherApIsClient.cs)

## AbExperimentService

> Source: [AbExperimentService](Api/AbExperimentService.cs)

<details>
<summary><code>Task&lt;DeAbExperiment&gt; AbExperimentServiceCreateAbExperiment(AbExperimentServiceCreateAbExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a managed control/variant split across two to 20 deployments under the same endpoint. Exactly one member is the control, member percentages must add up to 100, and the split applies only to traffic that the endpoint would otherwise send to the control.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AbExperimentService.AbExperimentServiceCreateAbExperiment(
        new AbExperimentServiceCreateAbExperimentRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            Body = new DeCreateAbExperimentRequest
            {
                Name = "some example string",
                Members = [
                    new DeAbExperimentMember
                    {
                        DeploymentId = "some example string",
                        Role = Role.AbExperimentMemberRoleControl,
                        Percent = 1,
                    },
                ],
            },
        });
    // TODO: Handle 'response' of type DeAbExperiment
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AbExperimentServiceCreateAbExperimentRequest](Requests/AbExperimentService/AbExperimentServiceCreateAbExperimentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeAbExperiment](Models/DeAbExperiment.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; AbExperimentServiceDeleteAbExperiment(AbExperimentServiceDeleteAbExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an A/B experiment and removes its managed traffic split. The deployments themselves are not deleted.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AbExperimentService.AbExperimentServiceDeleteAbExperiment(
        new AbExperimentServiceDeleteAbExperimentRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            Id = "some example string",
        });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AbExperimentServiceDeleteAbExperimentRequest](Requests/AbExperimentService/AbExperimentServiceDeleteAbExperimentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeAbExperiment&gt; AbExperimentServiceGetAbExperiment(AbExperimentServiceGetAbExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves an A/B experiment and its participating deployments, roles, and traffic percentages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AbExperimentService.AbExperimentServiceGetAbExperiment(
        new AbExperimentServiceGetAbExperimentRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            Id = "some example string",
        });
    // TODO: Handle 'response' of type DeAbExperiment
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AbExperimentServiceGetAbExperimentRequest](Requests/AbExperimentService/AbExperimentServiceGetAbExperimentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeAbExperiment](Models/DeAbExperiment.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListAbExperimentsResponse&gt; AbExperimentServiceListAbExperiments(AbExperimentServiceListAbExperimentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the managed live-traffic experiments configured for an endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AbExperimentService.AbExperimentServiceListAbExperiments(
        new AbExperimentServiceListAbExperimentsRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
        });
    // TODO: Handle 'response' of type DeListAbExperimentsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AbExperimentServiceListAbExperimentsRequest](Requests/AbExperimentService/AbExperimentServiceListAbExperimentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListAbExperimentsResponse](Models/DeListAbExperimentsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeAbExperiment&gt; AbExperimentServiceUpdateAbExperiment(AbExperimentServiceUpdateAbExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an experiment's description or member traffic percentages. Use the experiment etag for optimistic concurrency.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AbExperimentService.AbExperimentServiceUpdateAbExperiment(
        new AbExperimentServiceUpdateAbExperimentRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            Id = "some example string",
            Body = new DeUpdateAbExperimentRequest(),
        });
    // TODO: Handle 'response' of type DeAbExperiment
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AbExperimentServiceUpdateAbExperimentRequest](Requests/AbExperimentService/AbExperimentServiceUpdateAbExperimentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeAbExperiment](Models/DeAbExperiment.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Account

> Source: [Account](Api/Account.cs)

<details>
<summary><code>Task&lt;WhoamiResponse&gt; Whoami(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns identity information about the authenticated API key. Useful for confirming which project and organization a key is scoped to, and for obtaining the project slug used to compose the `model` value (`<project_slug>/<endpoint_slug>`) in dedicated endpoint inference calls.
Requires a Bearer API key in the `Authorization` header. Cookie, session, and SLS JWT credentials are not accepted.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Account.Whoami();
    // TODO: Handle 'response' of type WhoamiResponse
}
catch (ApiException<WhoamiError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WhoamiResponse](Models/WhoamiResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[WhoamiError](Errors/WhoamiError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AudioApi

> Source: [AudioApi](Api/AudioApi.cs)

<details>
<summary><code>Task&lt;BinaryContent&gt; AudioSpeech(AudioSpeechOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generate audio from input text

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AudioApi.AudioSpeech(new AudioSpeechOperationRequest());
    // TODO: Handle 'response' of type BinaryContent
}
catch (ApiException<AudioSpeechError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AudioSpeechOperationRequest](Requests/AudioApi/AudioSpeechOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>BinaryContent</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AudioSpeechError](Errors/AudioSpeechError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AudioTranscriptionResponse&gt; AudioTranscriptions(AudioTranscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Transcribes audio into text

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AudioApi.AudioTranscriptions(new AudioTranscriptionsRequest
    {
        File = Array.Empty<byte>(),
        Language = "en",
    });
    // TODO: Handle 'response' of type AudioTranscriptionResponse
}
catch (ApiException<AudioTranscriptionsError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AudioTranscriptionsRequest](Requests/AudioApi/AudioTranscriptionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AudioTranscriptionResponse](Models/AnyOf/AudioTranscriptionResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AudioTranscriptionsError](Errors/AudioTranscriptionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AudioTranslationResponse&gt; AudioTranslations(AudioTranslationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Translates audio into English

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AudioApi.AudioTranslations(new AudioTranslationsRequest
    {
        File = Array.Empty<byte>(),
        Language = "en",
    });
    // TODO: Handle 'response' of type AudioTranslationResponse
}
catch (ApiException<AudioTranslationsError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AudioTranslationsRequest](Requests/AudioApi/AudioTranslationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AudioTranslationResponse](Models/AnyOf/AudioTranslationResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AudioTranslationsError](Errors/AudioTranslationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RealtimeTranscription(RealtimeTranscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Establishes a WebSocket connection for real-time audio transcription. This endpoint uses WebSocket protocol (wss://api.together.ai/v1/realtime) for bidirectional streaming communication.

**Connection Setup:**
- Protocol: WebSocket (wss://)
- Authentication: Pass API key as Bearer token in Authorization header
- Parameters: Sent as query parameters (model, input_audio_format)

**Client Events:**
- `input_audio_buffer.append`: Send audio chunks as base64-encoded data
  ```json
  {
    "type": "input_audio_buffer.append",
    "audio": "<base64_encoded_audio_chunk>"
  }
  ```
- `input_audio_buffer.commit`: Signal end of audio stream. When VAD is enabled, the server automatically detects speech boundaries and emits `completed` events. When VAD is disabled, you must send `commit` to trigger transcription of the buffered audio.
  ```json
  {
    "type": "input_audio_buffer.commit"
  }
  ```
- `transcription_session.updated`: Update session configuration, including Voice Activity Detection (VAD) parameters. Send this after receiving `session.created`. Can also be sent at any time during the session to change VAD settings.
  ```json
  {
    "type": "transcription_session.updated",
    "session": {
      "turn_detection": {
        "type": "server_vad",
        "threshold": 0.3,
        "min_silence_duration_ms": 500,
        "min_speech_duration_ms": 250,
        "max_speech_duration_s": 5.0,
        "speech_pad_ms": 250
      }
    }
  }
  ```
  To disable VAD entirely (manual commit mode), set `turn_detection` to `null`:
  ```json
  {
    "type": "transcription_session.updated",
    "session": {
      "turn_detection": null
    }
  }
  ```

**Voice Activity Detection (VAD)**

VAD controls how the server automatically detects speech segments in the audio stream. When enabled (the default), the server uses Silero VAD to identify speech regions and emits transcription events as each segment completes. When disabled, you must manually call `input_audio_buffer.commit` to trigger transcription.

VAD can be configured in two ways:
1. **Query parameters** at connection time: `turn_detection=server_vad&threshold=0.3&min_silence_duration_ms=500`
2. **Session message** after connection: Send `transcription_session.updated` with a `turn_detection` object (see above)

To disable VAD at connection time, use `turn_detection=none` as a query parameter.

**VAD Parameters:**

All parameters are Omitted fields use their defaults.

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `type` | string | `server_vad` | VAD mode. Use `server_vad` to enable, or set `turn_detection` to `null` to disable. |
| `threshold` | float | `0.3` | Speech probability threshold (0.0–1.0). Audio frames with probability above this value are classified as speech. Lower values detect more speech but may increase false positives. For low-SNR audio (e.g., 8kHz phone calls), values of 0.01–0.2 may work better. |
| `min_silence_duration_ms` | int | `500` | Minimum silence duration in milliseconds before ending a speech segment. Higher values merge nearby speech bursts into single segments. For phone calls with mid-sentence pauses, 2000–5000ms prevents over-segmentation. |
| `min_speech_duration_ms` | int | `250` | Minimum speech segment duration in milliseconds. Segments shorter than this are discarded. Filters out brief noise bursts or clicks. |
| `max_speech_duration_s` | float | `5.0` | Maximum speech segment duration in seconds. Segments longer than this are force-split at the longest internal silence gap. Useful for continuous speech without natural pauses. |
| `speech_pad_ms` | int | `250` | Padding in milliseconds added to the start and end of each detected segment. Prevents clipping speech edges. When padding would cause adjacent segments to overlap, the gap is split at the midpoint instead. |

**Server Events:**
- `session.created`: Initial session confirmation (sent first)
  ```json
  {
    "type": "session.created",
    "session": {
      "id": "session-id",
      "object": "realtime.session",
      "modalities": ["audio"],
      "model": "openai/whisper-large-v3"
    }
  }
  ```
- `transcription_session.updated`: Confirms session configuration was applied. Sent in response to a client `transcription_session.updated` message.
  ```json
  {
    "type": "transcription_session.updated",
    "session": {
      "turn_detection": {
        "type": "server_vad",
        "threshold": 0.3,
        "min_silence_duration_ms": 500,
        "min_speech_duration_ms": 250,
        "max_speech_duration_s": 5.0,
        "speech_pad_ms": 250
      }
    }
  }
  ```
- `conversation.item.input_audio_transcription.delta`: Partial transcription results
  ```json
  {
    "type": "conversation.item.input_audio_transcription.delta",
    "delta": "The quick brown"
  }
  ```
- `conversation.item.input_audio_transcription.completed`: Final transcription
  ```json
  {
    "type": "conversation.item.input_audio_transcription.completed",
    "transcript": "The quick brown fox jumps over the lazy dog"
  }
  ```
- `conversation.item.input_audio_transcription.failed`: Error occurred
  ```json
  {
    "type": "conversation.item.input_audio_transcription.failed",
    "error": {
      "message": "Error description",
      "type": "invalid_request_error",
      "param": null,
      "code": "invalid_api_key"
    }
  }
  ```

**Error Codes:**
- `invalid_api_key`: Invalid API key provided (401)
- `missing_api_key`: Authorization header missing (401)
- `model_not_available`: Invalid or unavailable model (400)
- Unsupported audio format errors (400)

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AudioApi.RealtimeTranscription(new RealtimeTranscriptionRequest
    {
        Model = "some example string",
        InputAudioFormat = InputAudioFormat.PcmS16Le16000,
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RealtimeTranscriptionRequest](Requests/AudioApi/RealtimeTranscriptionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RealtimeTts(RealtimeTtsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Establishes a WebSocket connection for real-time text-to-speech generation. This endpoint uses WebSocket protocol (wss://api.together.ai/v1/audio/speech/websocket) for bidirectional streaming communication.

**Connection Setup:**
- Protocol: WebSocket (wss://)
- Authentication: Pass API key as Bearer token in Authorization header
- Parameters: Sent as query parameters (model, voice, max_partial_length, language)

**Client Events:**
- `tts_session.updated`: Update session parameters like voice. The `session` object also accepts an `extra_params` field for additional model-specific parameters that fine-tune speech generation behavior, such as `pronunciation_dict` (a list of pronunciation rules for specific characters or symbols, where each entry uses the format `"<source>/<replacement>"` (e.g., `["omg/oh my god"]`) to override how the model pronounces matching tokens).
  ```json
  {
    "type": "tts_session.updated",
    "session": {
      "voice": "tara",
      "extra_params": {
        "pronunciation_dict": ["omg/oh my god"]
      }
    }
  }
  ```
- `input_text_buffer.append`: Send text chunks for TTS generation
  ```json
  {
    "type": "input_text_buffer.append",
    "text": "Hello, this is a test."
  }
  ```
- `input_text_buffer.clear`: Clear the buffered text
  ```json
  {
    "type": "input_text_buffer.clear"
  }
  ```
- `input_text_buffer.commit`: Signal end of text input and process remaining text
  ```json
  {
    "type": "input_text_buffer.commit"
  }
  ```

**Server Events:**
- `session.created`: Initial session confirmation (sent first)
  ```json
  {
    "event_id": "evt_123456",
    "type": "session.created",
    "session": {
      "id": "session-id",
      "object": "realtime.tts.session",
      "modalities": ["text", "audio"],
      "model": "hexgrad/Kokoro-82M",
      "voice": "tara"
    }
  }
  ```
- `conversation.item.input_text.received`: Acknowledgment that text was received
  ```json
  {
    "type": "conversation.item.input_text.received",
    "text": "Hello, this is a test."
  }
  ```
- `conversation.item.audio_output.delta`: Audio chunks as base64-encoded data
  ```json
  {
    "type": "conversation.item.audio_output.delta",
    "item_id": "tts_1",
    "delta": "<base64_encoded_audio_chunk>"
  }
  ```
- `conversation.item.audio_output.done`: Audio generation complete for an item
  ```json
  {
    "type": "conversation.item.audio_output.done",
    "item_id": "tts_1"
  }
  ```
- `conversation.item.tts.failed`: Error occurred
  ```json
  {
    "type": "conversation.item.tts.failed",
    "error": {
      "message": "Error description",
      "type": "invalid_request_error",
      "param": null,
      "code": "invalid_api_key"
    }
  }
  ```

**Text Processing:**
- Partial text (no sentence ending) is held in buffer until:
  - We believe that the text is complete enough to be processed for TTS generation
  - The partial text exceeds `max_partial_length` characters (default: 250)
  - The `input_text_buffer.commit` event is received

**Audio Format:**
- Format: Raw PCM (s16le, mono)
- Sample Rate: 24000 Hz
- Encoding: Base64 (per delta event)
- Delivered via `conversation.item.audio_output.delta` events

**Error Codes:**
- `invalid_api_key`: Invalid API key provided (401)
- `missing_api_key`: Authorization header missing (401)
- `model_not_available`: Invalid or unavailable model (400)
- Invalid text format errors (400)

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AudioApi.RealtimeTts(new RealtimeTtsRequest { Language = "en" });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RealtimeTtsRequest](Requests/AudioApi/RealtimeTtsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Batches

> Source: [Batches](Api/Batches.cs)

<details>
<summary><code>Task&lt;BatchJob&gt; CancelABatchJob(CancelABatchJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel a batch job by ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Batches.CancelABatchJob(new CancelABatchJobRequest { Id = "batch_job_abc123def456" });
    // TODO: Handle 'response' of type BatchJob
}
catch (ApiException<CancelABatchJobError> ex)
{
    if (ex.Error.TryGetBatchErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type BatchErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelABatchJobRequest](Requests/Batches/CancelABatchJobRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchJob](Models/BatchJob.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CancelABatchJobError](Errors/CancelABatchJobError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchJobWithWarning&gt; CreateABatchJob(CreateABatchJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new batch job with the given input file and endpoint

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Batches.CreateABatchJob(new CreateABatchJobRequest
    {
        Body = new CreateBatchRequest { Endpoint = Endpoint.V1ChatCompletions, InputFileId = "some example string" },
    });
    // TODO: Handle 'response' of type BatchJobWithWarning
}
catch (ApiException<CreateABatchJobError> ex)
{
    if (ex.Error.TryGetBatchErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type BatchErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateABatchJobRequest](Requests/Batches/CreateABatchJobRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchJobWithWarning](Models/BatchJobWithWarning.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreateABatchJobError](Errors/CreateABatchJobError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BatchJob&gt; GetABatchJob(GetABatchJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get details of a batch job by ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Batches.GetABatchJob(new GetABatchJobRequest { Id = "batch_job_abc123def456" });
    // TODO: Handle 'response' of type BatchJob
}
catch (ApiException<GetABatchJobError> ex)
{
    if (ex.Error.TryGetBatchErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type BatchErrorResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetABatchJobRequest](Requests/Batches/GetABatchJobRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BatchJob](Models/BatchJob.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetABatchJobError](Errors/GetABatchJobError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;BatchJob&gt;&gt; ListBatchJobs(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all batch jobs for the authenticated user

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Batches.ListBatchJobs();
    // TODO: Handle 'response' of type IReadOnlyList<BatchJob>
}
catch (ApiException<ListBatchJobsError> ex)
{
    if (ex.Error.TryGetBatchErrorResponse(out var error))
    {
        // TODO: Handle 'error' of type BatchErrorResponse
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[BatchJob](Models/BatchJob.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ListBatchJobsError](Errors/ListBatchJobsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Billing

> Source: [Billing](Api/Billing.cs)

<details>
<summary><code>Task&lt;BillingUsageReport&gt; GetBillingUsage(GetBillingUsageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns an organization's billing usage for a month as cost-annotated line items grouped into time windows. Finalized windows are returned through the end of yesterday at daily granularity, or the last completed hour at hourly granularity (UTC).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Billing.GetBillingUsage(new GetBillingUsageRequest());
    // TODO: Handle 'response' of type BillingUsageReport
}
catch (ApiException<GetBillingUsageError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBillingUsageRequest](Requests/Billing/GetBillingUsageRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BillingUsageReport](Models/BillingUsageReport.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetBillingUsageError](Errors/GetBillingUsageError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Chat

> Source: [Chat](Api/Chat.cs)

<details>
<summary><code>Task&lt;ChatCompletionResponse&gt; ChatCompletions(ChatCompletionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generate a model response for a given chat conversation. Supports single queries and multi-turn conversations with system, user, and assistant messages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Chat.ChatCompletions(new ChatCompletionsRequest());
    // TODO: Handle 'response' of type ChatCompletionResponse
}
catch (ApiException<ChatCompletionsError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ChatCompletionsRequest](Requests/Chat/ChatCompletionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChatCompletionResponse](Models/ChatCompletionResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ChatCompletionsError](Errors/ChatCompletionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CodeInterpreter

> Source: [CodeInterpreter](Api/CodeInterpreter.cs)

<details>
<summary><code>Task&lt;SessionListResponse&gt; SessionsList(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all your currently active sessions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CodeInterpreter.SessionsList();
    // TODO: Handle 'response' of type SessionListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SessionListResponse](Models/SessionListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ExecuteResponse&gt; TciExecute(TciExecuteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Executes the given code snippet and returns the output. Without a session_id, a new session is created to run the code. If you pass a valid session_id, the code runs in that session. This is useful for running multiple code snippets in the same environment, because dependencies and similar things are persisted
between calls to the same session.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CodeInterpreter.TciExecute(new TciExecuteRequest());
    // TODO: Handle 'response' of type ExecuteResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TciExecuteRequest](Requests/CodeInterpreter/TciExecuteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ExecuteResponse](Models/AnyOf/ExecuteResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Completion

> Source: [Completion](Api/Completion.cs)

<details>
<summary><code>Task&lt;CompletionResponse&gt; Completions(CompletionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generate text completions for a given prompt using a language, code, or image model.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Completion.Completions(new CompletionsRequest());
    // TODO: Handle 'response' of type CompletionResponse
}
catch (ApiException<CompletionsError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CompletionsRequest](Requests/Completion/CompletionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CompletionResponse](Models/CompletionResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CompletionsError](Errors/CompletionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ConfigService

> Source: [ConfigService](Api/ConfigService.cs)

<details>
<summary><code>Task&lt;DeModelConfig&gt; ConfigServiceGetProjectConfig(ConfigServiceGetProjectConfigRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a model configuration revision by ID, including its runtime selectors and certifications.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConfigService.ConfigServiceGetProjectConfig(new ConfigServiceGetProjectConfigRequest
    {
        ProjectId = "some example string",
        Id = "some example string",
    });
    // TODO: Handle 'response' of type DeModelConfig
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConfigServiceGetProjectConfigRequest](Requests/ConfigService/ConfigServiceGetProjectConfigRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeModelConfig](Models/DeModelConfig.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListProjectConfigsResponse&gt; ConfigServiceListProjectConfigs(ConfigServiceListProjectConfigsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists production-ready configuration revisions compatible with a reference model. Specify the model with `referenceModel` or the deprecated `referenceModelId`; if both are supplied, they must identify the same model. Results include public configurations and configurations owned by the specified project.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConfigService.ConfigServiceListProjectConfigs(new ConfigServiceListProjectConfigsRequest
    {
        ProjectId = "some example string",
    });
    // TODO: Handle 'response' of type DeListProjectConfigsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConfigServiceListProjectConfigsRequest](Requests/ConfigService/ConfigServiceListProjectConfigsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListProjectConfigsResponse](Models/DeListProjectConfigsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeploymentService

> Source: [DeploymentService](Api/DeploymentService.cs)

<details>
<summary><code>Task&lt;DeAdapterEntry&gt; DeploymentServiceAddAdapter(DeploymentServiceAddAdapterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Attaches a LoRA adapter to a deployment. If the deployment is at adapter capacity, force can evict the oldest adapter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeploymentService.DeploymentServiceAddAdapter(new DeploymentServiceAddAdapterRequest
    {
        ProjectId = "some example string",
        EndpointId = "some example string",
        DeploymentId = "some example string",
        Body = new DeAddAdapterRequest { AdapterModelId = "some example string" },
    });
    // TODO: Handle 'response' of type DeAdapterEntry
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeploymentServiceAddAdapterRequest](Requests/DeploymentService/DeploymentServiceAddAdapterRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeAdapterEntry](Models/DeAdapterEntry.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeDeployment&gt; DeploymentServiceCreateDeployment(DeploymentServiceCreateDeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a model deployment under an endpoint. The deployment provisions asynchronously; monitor its status before routing live traffic to it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeploymentService.DeploymentServiceCreateDeployment(
        new DeploymentServiceCreateDeploymentRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            Body = new DeCreateDeploymentRequest { Name = "some example string", Autoscaling = new DeAutoscaling() },
        });
    // TODO: Handle 'response' of type DeDeployment
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeploymentServiceCreateDeploymentRequest](Requests/DeploymentService/DeploymentServiceCreateDeploymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeDeployment](Models/DeDeployment.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; DeploymentServiceDeleteDeployment(DeploymentServiceDeleteDeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Permanently deletes a deployment from its endpoint. Remove the deployment from live traffic first; use `etag` to reject the request if it changed after it was read.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeploymentService.DeploymentServiceDeleteDeployment(
        new DeploymentServiceDeleteDeploymentRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            Id = "some example string",
        });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeploymentServiceDeleteDeploymentRequest](Requests/DeploymentService/DeploymentServiceDeleteDeploymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeAdapterEntry&gt; DeploymentServiceGetAdapter(DeploymentServiceGetAdapterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets an attached adapter and its per-cluster load state.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeploymentService.DeploymentServiceGetAdapter(new DeploymentServiceGetAdapterRequest
    {
        ProjectId = "some example string",
        EndpointId = "some example string",
        DeploymentId = "some example string",
        Id = "some example string",
    });
    // TODO: Handle 'response' of type DeAdapterEntry
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeploymentServiceGetAdapterRequest](Requests/DeploymentService/DeploymentServiceGetAdapterRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeAdapterEntry](Models/DeAdapterEntry.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeDeployment&gt; DeploymentServiceGetDeployment(DeploymentServiceGetDeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a deployment's desired configuration, placement, runtime information, and current provisioning status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeploymentService.DeploymentServiceGetDeployment(
        new DeploymentServiceGetDeploymentRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            Id = "some example string",
        });
    // TODO: Handle 'response' of type DeDeployment
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeploymentServiceGetDeploymentRequest](Requests/DeploymentService/DeploymentServiceGetDeploymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeDeployment](Models/DeDeployment.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListAdaptersResponse&gt; DeploymentServiceListAdapters(DeploymentServiceListAdaptersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists LoRA adapters attached to a deployment with per-cluster load state.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeploymentService.DeploymentServiceListAdapters(new DeploymentServiceListAdaptersRequest
    {
        ProjectId = "some example string",
        EndpointId = "some example string",
        DeploymentId = "some example string",
    });
    // TODO: Handle 'response' of type DeListAdaptersResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeploymentServiceListAdaptersRequest](Requests/DeploymentService/DeploymentServiceListAdaptersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListAdaptersResponse](Models/DeListAdaptersResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListDeploymentsResponse&gt; DeploymentServiceListDeployments(DeploymentServiceListDeploymentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the deployments attached to an endpoint, including their model, configuration, scaling settings, placement, and current status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeploymentService.DeploymentServiceListDeployments(
        new DeploymentServiceListDeploymentsRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
        });
    // TODO: Handle 'response' of type DeListDeploymentsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeploymentServiceListDeploymentsRequest](Requests/DeploymentService/DeploymentServiceListDeploymentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListDeploymentsResponse](Models/DeListDeploymentsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; DeploymentServiceRemoveAdapter(DeploymentServiceRemoveAdapterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Detaches an adapter from a deployment using its row-level etag for optimistic concurrency.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeploymentService.DeploymentServiceRemoveAdapter(
        new DeploymentServiceRemoveAdapterRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            DeploymentId = "some example string",
            Id = "some example string",
            Etag = "some example string",
        });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeploymentServiceRemoveAdapterRequest](Requests/DeploymentService/DeploymentServiceRemoveAdapterRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeAdapterEntry&gt; DeploymentServiceUpdateAdapter(DeploymentServiceUpdateAdapterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the pinned revision of an attached adapter using its row-level etag for optimistic concurrency.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeploymentService.DeploymentServiceUpdateAdapter(
        new DeploymentServiceUpdateAdapterRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            DeploymentId = "some example string",
            Id = "some example string",
            Body = new DeUpdateAdapterRequest
            {
                AdapterRevisionId = "some example string",
                Etag = "some example string",
            },
        });
    // TODO: Handle 'response' of type DeAdapterEntry
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeploymentServiceUpdateAdapterRequest](Requests/DeploymentService/DeploymentServiceUpdateAdapterRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeAdapterEntry](Models/DeAdapterEntry.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeDeployment&gt; DeploymentServiceUpdateDeployment(DeploymentServiceUpdateDeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates mutable deployment fields such as its model, configuration, autoscaling bounds, or LoRA support. Changes that affect serving may trigger asynchronous reprovisioning.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeploymentService.DeploymentServiceUpdateDeployment(
        new DeploymentServiceUpdateDeploymentRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            Id = "some example string",
            Body = new DeUpdateDeploymentRequest(),
        });
    // TODO: Handle 'response' of type DeDeployment
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeploymentServiceUpdateDeploymentRequest](Requests/DeploymentService/DeploymentServiceUpdateDeploymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeDeployment](Models/DeDeployment.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Deployments

> Source: [Deployments](Api/Deployments.cs)

<details>
<summary><code>Task&lt;DeploymentResponseItem&gt; CreateANewDeployment(CreateANewDeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new deployment with specified configuration

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Deployments.CreateANewDeployment(new CreateANewDeploymentRequest
    {
        Body = new CreateDeploymentRequest
        {
            GpuType = GpuType5.H10080Gb,
            Image = "some example string",
            Name = "some example string",
        },
    });
    // TODO: Handle 'response' of type DeploymentResponseItem
}
catch (ApiException<CreateANewDeploymentError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateANewDeploymentRequest](Requests/Deployments/CreateANewDeploymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeploymentResponseItem](Models/DeploymentResponseItem.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreateANewDeploymentError](Errors/CreateANewDeploymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; DeleteADeployment(DeleteADeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an existing deployment

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Deployments.DeleteADeployment(new DeleteADeploymentRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<DeleteADeploymentError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteADeploymentRequest](Requests/Deployments/DeleteADeploymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteADeploymentError](Errors/DeleteADeploymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeploymentResponseItem&gt; GetADeploymentByIdOrName(GetADeploymentByIdOrNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve details of a specific deployment by its ID or name

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Deployments.GetADeploymentByIdOrName(new GetADeploymentByIdOrNameRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type DeploymentResponseItem
}
catch (ApiException<GetADeploymentByIdOrNameError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetADeploymentByIdOrNameRequest](Requests/Deployments/GetADeploymentByIdOrNameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeploymentResponseItem](Models/DeploymentResponseItem.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetADeploymentByIdOrNameError](Errors/GetADeploymentByIdOrNameError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeploymentLogs&gt; GetLogsForADeployment(GetLogsForADeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve logs from a deployment, optionally filtered by replica ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Deployments.GetLogsForADeployment(new GetLogsForADeploymentRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type DeploymentLogs
}
catch (ApiException<GetLogsForADeploymentError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetLogsForADeploymentRequest](Requests/Deployments/GetLogsForADeploymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeploymentLogs](Models/DeploymentLogs.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetLogsForADeploymentError](Errors/GetLogsForADeploymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RevisionDetailResponse&gt; GetTheFullConfigurationOfASpecificRevision(GetTheFullConfigurationOfASpecificRevisionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the deployment configuration defined by the specified revision.
Only the 50 most recent revisions per deployment retain their configuration; older revisions return 404 even while they still appear in the revision history.
The deployment's currently active revision is always available, regardless of age.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Deployments.GetTheFullConfigurationOfASpecificRevision(
        new GetTheFullConfigurationOfASpecificRevisionRequest
        {
            Id = "some example string",
            RevisionIdentifier = "some example string",
        });
    // TODO: Handle 'response' of type RevisionDetailResponse
}
catch (ApiException<GetTheFullConfigurationOfASpecificRevisionError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTheFullConfigurationOfASpecificRevisionRequest](Requests/Deployments/GetTheFullConfigurationOfASpecificRevisionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RevisionDetailResponse](Models/RevisionDetailResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTheFullConfigurationOfASpecificRevisionError](Errors/GetTheFullConfigurationOfASpecificRevisionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeploymentListResponse&gt; GetTheListOfDeployments(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a list of all deployments in your project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Deployments.GetTheListOfDeployments();
    // TODO: Handle 'response' of type DeploymentListResponse
}
catch (ApiException<GetTheListOfDeploymentsError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeploymentListResponse](Models/DeploymentListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTheListOfDeploymentsError](Errors/GetTheListOfDeploymentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RevisionEventListResponse&gt; ListRevisionHistoryEventsOfADeployment(ListRevisionHistoryEventsOfADeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the revision history of the deployment, in descending order. Defaults to the most recent events.
Only the 200 most recent events are retained per deployment; paginating past that returns an empty list.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Deployments.ListRevisionHistoryEventsOfADeployment(
        new ListRevisionHistoryEventsOfADeploymentRequest { Id = "some example string" });
    // TODO: Handle 'response' of type RevisionEventListResponse
}
catch (ApiException<ListRevisionHistoryEventsOfADeploymentError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListRevisionHistoryEventsOfADeploymentRequest](Requests/Deployments/ListRevisionHistoryEventsOfADeploymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RevisionEventListResponse](Models/RevisionEventListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ListRevisionHistoryEventsOfADeploymentError](Errors/ListRevisionHistoryEventsOfADeploymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeploymentResponseItem&gt; RollBackADeploymentToAPreviousRevision(RollBackADeploymentToAPreviousRevisionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Re-applies the spec of a previous revision. Pods running the target revision will be retained. Other pods will be drained and restarted with the target revision.
Only the 50 most recent revisions per deployment can be rolled back to; older targets return 404.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Deployments.RollBackADeploymentToAPreviousRevision(
        new RollBackADeploymentToAPreviousRevisionRequest
        {
            Id = "some example string",
            Body = new RollbackDeploymentRequest { RevisionIdentifier = "some example string" },
        });
    // TODO: Handle 'response' of type DeploymentResponseItem
}
catch (ApiException<RollBackADeploymentToAPreviousRevisionError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RollBackADeploymentToAPreviousRevisionRequest](Requests/Deployments/RollBackADeploymentToAPreviousRevisionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeploymentResponseItem](Models/DeploymentResponseItem.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RollBackADeploymentToAPreviousRevisionError](Errors/RollBackADeploymentToAPreviousRevisionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeploymentResponseItem&gt; UpdateADeployment(UpdateADeploymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an existing deployment configuration

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Deployments.UpdateADeployment(new UpdateADeploymentRequest
    {
        Id = "some example string",
        Body = new UpdateDeploymentRequest(),
    });
    // TODO: Handle 'response' of type DeploymentResponseItem
}
catch (ApiException<UpdateADeploymentError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateADeploymentRequest](Requests/Deployments/UpdateADeploymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeploymentResponseItem](Models/DeploymentResponseItem.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UpdateADeploymentError](Errors/UpdateADeploymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeploymentsStorage

> Source: [DeploymentsStorage](Api/DeploymentsStorage.cs)

<details>
<summary><code>Task DownloadAFile(DownloadAFileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Download a file by redirecting to a signed URL

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DeploymentsStorage.DownloadAFile(new DownloadAFileRequest { Filename = "some example string" });
}
catch (ApiException<DownloadAFileError> ex)
{
    if (ex.Error.TryGetMapOfString(out var error))
    {
        // TODO: Handle 'error' of type IReadOnlyDictionary<string, string>
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DownloadAFileRequest](Requests/DeploymentsStorage/DownloadAFileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DownloadAFileError](Errors/DownloadAFileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignedUrlResponse&gt; GetAFileDownloadUrl(GetAFileDownloadUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a signed URL for downloading a deployment storage file

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeploymentsStorage.GetAFileDownloadUrl(new GetAFileDownloadUrlRequest
    {
        Filename = "some example string",
    });
    // TODO: Handle 'response' of type SignedUrlResponse
}
catch (ApiException<GetAFileDownloadUrlError> ex)
{
    if (ex.Error.TryGetMapOfString(out var error))
    {
        // TODO: Handle 'error' of type IReadOnlyDictionary<string, string>
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAFileDownloadUrlRequest](Requests/DeploymentsStorage/GetAFileDownloadUrlRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignedUrlResponse](Models/SignedUrlResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAFileDownloadUrlError](Errors/GetAFileDownloadUrlError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DeploymentsVolumes

> Source: [DeploymentsVolumes](Api/DeploymentsVolumes.cs)

<details>
<summary><code>Task&lt;VolumeResponseItem&gt; CreateANewVolume(CreateANewVolumeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new volume to preload files in deployments

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeploymentsVolumes.CreateANewVolume(new CreateANewVolumeRequest
    {
        Body = new CreateVolumeRequest
        {
            Content = new VolumeContentRequest(),
            Name = "some example string",
            Type = VolumeType.VolumeTypeReadOnly,
        },
    });
    // TODO: Handle 'response' of type VolumeResponseItem
}
catch (ApiException<CreateANewVolumeError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateANewVolumeRequest](Requests/DeploymentsVolumes/CreateANewVolumeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VolumeResponseItem](Models/VolumeResponseItem.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreateANewVolumeError](Errors/CreateANewVolumeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListVolumesResponse&gt; GetTheListOfProjectVolumes(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve all volumes in your project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DeploymentsVolumes.GetTheListOfProjectVolumes();
    // TODO: Handle 'response' of type ListVolumesResponse
}
catch (ApiException<GetTheListOfProjectVolumesError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListVolumesResponse](Models/ListVolumesResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTheListOfProjectVolumesError](Errors/GetTheListOfProjectVolumesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Embeddings

> Source: [Embeddings](Api/Embeddings.cs)

<details>
<summary><code>Task&lt;EmbeddingsResponse&gt; EmbeddingsInvoke(EmbeddingsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Generate vector embeddings for one or more text inputs. Returns numerical arrays representing semantic meaning, useful for search, classification, and retrieval.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Embeddings.EmbeddingsInvoke(new EmbeddingsOperationRequest());
    // TODO: Handle 'response' of type EmbeddingsResponse
}
catch (ApiException<EmbeddingsError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EmbeddingsOperationRequest](Requests/Embeddings/EmbeddingsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EmbeddingsResponse](Models/EmbeddingsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[EmbeddingsError](Errors/EmbeddingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EndpointService

> Source: [EndpointService](Api/EndpointService.cs)

<details>
<summary><code>Task&lt;DeEndpoint&gt; EndpointServiceCreateEndpoint(EndpointServiceCreateEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a stable, inference-addressable endpoint. Add one or more deployments and configure its traffic split before sending inference requests to the endpoint name.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EndpointService.EndpointServiceCreateEndpoint(new EndpointServiceCreateEndpointRequest
    {
        ProjectId = "some example string",
        Body = new DeCreateEndpointRequest { Name = "some example string" },
    });
    // TODO: Handle 'response' of type DeEndpoint
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EndpointServiceCreateEndpointRequest](Requests/EndpointService/EndpointServiceCreateEndpointRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeEndpoint](Models/DeEndpoint.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; EndpointServiceDeleteEndpoint(EndpointServiceDeleteEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Permanently deletes an endpoint. Delete its deployments first; use `etag` to reject the request if the endpoint changed after it was read.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EndpointService.EndpointServiceDeleteEndpoint(new EndpointServiceDeleteEndpointRequest
    {
        ProjectId = "some example string",
        Id = "some example string",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EndpointServiceDeleteEndpointRequest](Requests/EndpointService/EndpointServiceDeleteEndpointRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeEndpoint&gt; EndpointServiceGetEndpoint(EndpointServiceGetEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves an endpoint and lightweight summaries of the deployments attached to it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EndpointService.EndpointServiceGetEndpoint(new EndpointServiceGetEndpointRequest
    {
        ProjectId = "some example string",
        Id = "some example string",
    });
    // TODO: Handle 'response' of type DeEndpoint
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EndpointServiceGetEndpointRequest](Requests/EndpointService/EndpointServiceGetEndpointRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeEndpoint](Models/DeEndpoint.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeAnalyticsData&gt; EndpointServiceGetEndpointAnalytics(EndpointServiceGetEndpointAnalyticsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns aggregated request, token, latency, throughput, error, and resource-utilization metrics for an endpoint over a time range. Optionally includes time-series buckets and a per-deployment breakdown.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EndpointService.EndpointServiceGetEndpointAnalytics(
        new EndpointServiceGetEndpointAnalyticsRequest
        {
            ProjectId = "some example string",
            Id = "some example string",
        });
    // TODO: Handle 'response' of type DeAnalyticsData
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EndpointServiceGetEndpointAnalyticsRequest](Requests/EndpointService/EndpointServiceGetEndpointAnalyticsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeAnalyticsData](Models/DeAnalyticsData.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListEndpointEventsResponse&gt; EndpointServiceListEndpointEvents(EndpointServiceListEndpointEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists an endpoint's audit and lifecycle events newest first. The feed combines endpoint changes with provisioning, scaling, readiness, rollout, and other events from deployments under the endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EndpointService.EndpointServiceListEndpointEvents(
        new EndpointServiceListEndpointEventsRequest { ProjectId = "some example string", Id = "some example string" });
    // TODO: Handle 'response' of type DeListEndpointEventsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EndpointServiceListEndpointEventsRequest](Requests/EndpointService/EndpointServiceListEndpointEventsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListEndpointEventsResponse](Models/DeListEndpointEventsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListEndpointsResponse&gt; EndpointServiceListEndpoints(EndpointServiceListEndpointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the dedicated inference endpoints owned by the specified project.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EndpointService.EndpointServiceListEndpoints(new EndpointServiceListEndpointsRequest
    {
        ProjectId = "some example string",
    });
    // TODO: Handle 'response' of type DeListEndpointsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EndpointServiceListEndpointsRequest](Requests/EndpointService/EndpointServiceListEndpointsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListEndpointsResponse](Models/DeListEndpointsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListEndpointsResponse&gt; EndpointServiceListOrganizationEndpoints(EndpointServiceListOrganizationEndpointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists endpoints shared with every project in the specified organization. Project-private and public endpoints are not included.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EndpointService.EndpointServiceListOrganizationEndpoints(
        new EndpointServiceListOrganizationEndpointsRequest { OrganizationId = "some example string" });
    // TODO: Handle 'response' of type DeListEndpointsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EndpointServiceListOrganizationEndpointsRequest](Requests/EndpointService/EndpointServiceListOrganizationEndpointsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListEndpointsResponse](Models/DeListEndpointsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListPublicEndpointsResponse&gt; EndpointServiceListPublicEndpoints(EndpointServiceListPublicEndpointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists endpoints that are publicly visible across Together projects.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EndpointService.EndpointServiceListPublicEndpoints(
        new EndpointServiceListPublicEndpointsRequest());
    // TODO: Handle 'response' of type DeListPublicEndpointsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EndpointServiceListPublicEndpointsRequest](Requests/EndpointService/EndpointServiceListPublicEndpointsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListPublicEndpointsResponse](Models/DeListPublicEndpointsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeEndpoint&gt; EndpointServiceUpdateEndpoint(EndpointServiceUpdateEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates mutable endpoint fields such as its endpoint string, visibility, or deployment traffic split. Use `updateMask` to select fields explicitly and `etag` in the request body for optimistic concurrency.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EndpointService.EndpointServiceUpdateEndpoint(new EndpointServiceUpdateEndpointRequest
    {
        ProjectId = "some example string",
        Id = "some example string",
        Body = new DeEndpointUpdate(),
    });
    // TODO: Handle 'response' of type DeEndpoint
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EndpointServiceUpdateEndpointRequest](Requests/EndpointService/EndpointServiceUpdateEndpointRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeEndpoint](Models/DeEndpoint.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Endpoints

> Source: [Endpoints](Api/Endpoints.cs)

<details>
<summary><code>Task&lt;EndpointsAdaptersResponse&gt; AddAdapter(AddAdapterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a LoRA adapter model to a dedicated endpoint. After this call,
inference requests to the adapter model name will be routed to the
specified endpoint. The endpoint must have LoRA enabled, and the
adapter's base model must be compatible with the endpoint's model.
The endpoint name prefix in model_id must match the resolved endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Endpoints.AddAdapter(new AddAdapterRequest
    {
        EndpointId = "some example string",
        Body = new EndpointsAdaptersRequest { ModelId = "some example string" },
    });
    // TODO: Handle 'response' of type EndpointsAdaptersResponse
}
catch (ApiException<AddAdapterError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AddAdapterRequest](Requests/Endpoints/AddAdapterRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EndpointsAdaptersResponse](Models/EndpointsAdaptersResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AddAdapterError](Errors/AddAdapterError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListAvailibilityZonesResponse&gt; AvailabilityZones(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all available availability zones.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Endpoints.AvailabilityZones();
    // TODO: Handle 'response' of type ListAvailibilityZonesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListAvailibilityZonesResponse](Models/ListAvailibilityZonesResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DedicatedEndpoint&gt; CreateEndpoint(CreateEndpointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new dedicated endpoint for serving models. The endpoint starts automatically after creation. You can deploy any supported model on hardware configurations that meet the model's requirements.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Endpoints.CreateEndpoint(new CreateEndpointOperationRequest
    {
        Body = new CreateEndpointRequest
        {
            Model = "some example string",
            Hardware = "some example string",
            Autoscaling = new Autoscaling1 { MinReplicas = 1, MaxReplicas = 1 },
        },
    });
    // TODO: Handle 'response' of type DedicatedEndpoint
}
catch (ApiException<CreateEndpointError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateEndpointOperationRequest](Requests/Endpoints/CreateEndpointOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DedicatedEndpoint](Models/DedicatedEndpoint.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreateEndpointError](Errors/CreateEndpointError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteEndpoint(DeleteEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Permanently deletes an endpoint. This action cannot be undone.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Endpoints.DeleteEndpoint(new DeleteEndpointRequest
    {
        EndpointId = "endpoint-d23901de-ef8f-44bf-b3e7-de9c1ca8f2d7",
    });
}
catch (ApiException<DeleteEndpointError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteEndpointRequest](Requests/Endpoints/DeleteEndpointRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteEndpointError](Errors/DeleteEndpointError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DedicatedEndpoint&gt; GetEndpoint(GetEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves details about a specific endpoint, including its current state, configuration, and scaling settings.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Endpoints.GetEndpoint(new GetEndpointRequest
    {
        EndpointId = "endpoint-d23901de-ef8f-44bf-b3e7-de9c1ca8f2d7",
    });
    // TODO: Handle 'response' of type DedicatedEndpoint
}
catch (ApiException<GetEndpointError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEndpointRequest](Requests/Endpoints/GetEndpointRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DedicatedEndpoint](Models/DedicatedEndpoint.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEndpointError](Errors/GetEndpointError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EndpointsAdaptersResponse1&gt; ListAdapters(ListAdaptersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns all LoRA adapters bound to the specified dedicated endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Endpoints.ListAdapters(new ListAdaptersRequest { EndpointId = "some example string" });
    // TODO: Handle 'response' of type EndpointsAdaptersResponse1
}
catch (ApiException<ListAdaptersError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListAdaptersRequest](Requests/Endpoints/ListAdaptersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EndpointsAdaptersResponse1](Models/EndpointsAdaptersResponse1.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ListAdaptersError](Errors/ListAdaptersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EndpointsResponse&gt; ListEndpoints(ListEndpointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all endpoints associated with your account. You can filter the results by type (dedicated or serverless).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Endpoints.ListEndpoints(new ListEndpointsRequest());
    // TODO: Handle 'response' of type EndpointsResponse
}
catch (ApiException<ListEndpointsError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListEndpointsRequest](Requests/Endpoints/ListEndpointsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EndpointsResponse](Models/EndpointsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ListEndpointsError](Errors/ListEndpointsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EndpointsAdaptersResponse2&gt; RemoveAdapter(RemoveAdapterRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the routing rule that binds an adapter to an endpoint.
The adapter must be currently bound to this specific endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Endpoints.RemoveAdapter(new RemoveAdapterRequest
    {
        EndpointId = "some example string",
        Body = new EndpointsAdaptersRequest { ModelId = "some example string" },
    });
    // TODO: Handle 'response' of type EndpointsAdaptersResponse2
}
catch (ApiException<RemoveAdapterError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemoveAdapterRequest](Requests/Endpoints/RemoveAdapterRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EndpointsAdaptersResponse2](Models/EndpointsAdaptersResponse2.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RemoveAdapterError](Errors/RemoveAdapterError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DedicatedEndpoint&gt; UpdateEndpoint(UpdateEndpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing endpoint's configuration. You can modify the display name, autoscaling settings, or change the endpoint's state (start/stop).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Endpoints.UpdateEndpoint(new UpdateEndpointRequest
    {
        EndpointId = "endpoint-d23901de-ef8f-44bf-b3e7-de9c1ca8f2d7",
        Body = new EndpointsRequest(),
    });
    // TODO: Handle 'response' of type DedicatedEndpoint
}
catch (ApiException<UpdateEndpointError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateEndpointRequest](Requests/Endpoints/UpdateEndpointRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DedicatedEndpoint](Models/DedicatedEndpoint.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UpdateEndpointError](Errors/UpdateEndpointError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Files

> Source: [Files](Api/Files.cs)

<details>
<summary><code>Task&lt;FileDeleteResponse&gt; DeleteAFile(DeleteAFileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a previously uploaded data file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.DeleteAFile(new DeleteAFileRequest { Id = "some example string" });
    // TODO: Handle 'response' of type FileDeleteResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteAFileRequest](Requests/Files/DeleteAFileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FileDeleteResponse](Models/FileDeleteResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetFileContents(GetFileContentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the contents of a single uploaded data file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Files.GetFileContents(new GetFileContentsRequest { Id = "some example string" });
}
catch (ApiException<GetFileContentsError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFileContentsRequest](Requests/Files/GetFileContentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetFileContentsError](Errors/GetFileContentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FileList&gt; ListAllFiles(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List the metadata for all uploaded data files.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.ListAllFiles();
    // TODO: Handle 'response' of type FileList
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FileList](Models/FileList.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FileResponse&gt; RetrieveFileMetadata(RetrieveFileMetadataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve the metadata for a single uploaded data file.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.RetrieveFileMetadata(new RetrieveFileMetadataRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type FileResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveFileMetadataRequest](Requests/Files/RetrieveFileMetadataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FileResponse](Models/FileResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FileResponse&gt; UploadAFile(UploadAFileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Upload a file with specified purpose, file name, and file type.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Files.UploadAFile(new UploadAFileRequest
    {
        Purpose = FilePurpose.FineTune,
        FileName = "dataset.csv",
        File = Array.Empty<byte>(),
    });
    // TODO: Handle 'response' of type FileResponse
}
catch (ApiException<UploadAFileError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UploadAFileRequest](Requests/Files/UploadAFileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FileResponse](Models/FileResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UploadAFileError](Errors/UploadAFileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FineTuning

> Source: [FineTuning](Api/FineTuning.cs)

<details>
<summary><code>Task&lt;FinetuneResponseTruncated&gt; CancelJob(CancelJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel a currently running fine-tuning job. Returns a FinetuneResponseTruncated object.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FineTuning.CancelJob(new CancelJobRequest { Id = "some example string" });
    // TODO: Handle 'response' of type FinetuneResponseTruncated
}
catch (ApiException<CancelJobError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelJobRequest](Requests/FineTuning/CancelJobRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FinetuneResponseTruncated](Models/FinetuneResponseTruncated.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CancelJobError](Errors/CancelJobError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FinetuneResponseTruncated&gt; CreateJob(CreateJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a fine-tuning job with the provided model and training data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FineTuning.CreateJob(new CreateJobRequest
    {
        Body = new FineTunesRequest { TrainingFile = "some example string", Model = "some example string" },
    });
    // TODO: Handle 'response' of type FinetuneResponseTruncated
}
catch (ApiException<CreateJobError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateJobRequest](Requests/FineTuning/CreateJobRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FinetuneResponseTruncated](Models/FinetuneResponseTruncated.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreateJobError](Errors/CreateJobError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FinetuneDeleteResponse&gt; DeleteAFineTuneJob(DeleteAFineTuneJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a fine-tuning job.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FineTuning.DeleteAFineTuneJob(new DeleteAFineTuneJobRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type FinetuneDeleteResponse
}
catch (ApiException<DeleteAFineTuneJobError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteAFineTuneJobRequest](Requests/FineTuning/DeleteAFineTuneJobRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FinetuneDeleteResponse](Models/FinetuneDeleteResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteAFineTuneJobError](Errors/DeleteAFineTuneJobError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BinaryContent&gt; DownloadModel(DownloadModelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Receive a compressed fine-tuned model or checkpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FineTuning.DownloadModel(new DownloadModelRequest { FtId = "some example string" });
    // TODO: Handle 'response' of type BinaryContent
}
catch (ApiException<DownloadModelError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DownloadModelRequest](Requests/FineTuning/DownloadModelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>BinaryContent</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DownloadModelError](Errors/DownloadModelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FineTuneTokenizedDatasetRetrieveResponse&gt; DownloadTokenizedDataset(DownloadTokenizedDatasetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a presigned URL for the tokenized dataset archive generated for a fine-tune job.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FineTuning.DownloadTokenizedDataset(new DownloadTokenizedDatasetRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type FineTuneTokenizedDatasetRetrieveResponse
}
catch (ApiException<DownloadTokenizedDatasetError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DownloadTokenizedDatasetRequest](Requests/FineTuning/DownloadTokenizedDatasetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FineTuneTokenizedDatasetRetrieveResponse](Models/FineTuneTokenizedDatasetRetrieveResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DownloadTokenizedDatasetError](Errors/DownloadTokenizedDatasetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FineTunesEstimatePriceResponse2&gt; EstimatePrice(EstimatePriceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Estimate the price of a fine-tuning job.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FineTuning.EstimatePrice(new EstimatePriceRequest
    {
        Body = new FineTunesEstimatePriceRequest { TrainingFile = "some example string" },
    });
    // TODO: Handle 'response' of type FineTunesEstimatePriceResponse2
}
catch (ApiException<EstimatePriceError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EstimatePriceRequest](Requests/FineTuning/EstimatePriceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FineTunesEstimatePriceResponse2](Models/AnyOf/FineTunesEstimatePriceResponse2.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[EstimatePriceError](Errors/EstimatePriceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FinetuneListCheckpoints&gt; GetFineTunesByIdByCheckpoints(GetFineTunesByIdByCheckpointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List the checkpoints for a single fine-tuning job.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FineTuning.GetFineTunesByIdByCheckpoints(new GetFineTunesByIdByCheckpointsRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type FinetuneListCheckpoints
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetFineTunesByIdByCheckpointsRequest](Requests/FineTuning/GetFineTunesByIdByCheckpointsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FinetuneListCheckpoints](Models/FinetuneListCheckpoints.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FineTunesModelsSupportedResponse&gt; GetFineTunesModelsSupported(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List models supported for fine-tuning.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FineTuning.GetFineTunesModelsSupported();
    // TODO: Handle 'response' of type FineTunesModelsSupportedResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FineTunesModelsSupportedResponse](Models/FineTunesModelsSupportedResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FineTunesMetricsResponse&gt; GetMetrics(GetMetricsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves recorded training metrics for a fine-tuning job in chronological order. All query parameters are optional: omit them to retrieve all metrics.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FineTuning.GetMetrics(new GetMetricsRequest
    {
        Id = "some example string",
        GlobalStepFrom = 0,
        GlobalStepTo = 500,
        LoggedAtFrom = DateTimeOffset.Parse("2024-01-01T00:00:00Z"),
        LoggedAtTo = DateTimeOffset.Parse("2024-01-01T12:00:00Z"),
        Resolution = 100,
    });
    // TODO: Handle 'response' of type FineTunesMetricsResponse
}
catch (ApiException<GetMetricsError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetMetricsRequest](Requests/FineTuning/GetMetricsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FineTunesMetricsResponse](Models/FineTunesMetricsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetMetricsError](Errors/GetMetricsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FineTuneModelLimits&gt; GetModelLimits(GetModelLimitsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get model limits for a specific fine-tuning model.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FineTuning.GetModelLimits(new GetModelLimitsRequest
    {
        ModelName = "some example string",
    });
    // TODO: Handle 'response' of type FineTuneModelLimits
}
catch (ApiException<GetModelLimitsError> ex)
{
    if (ex.Error.TryGetFineTunesModelsLimits404Error1(out var error))
    {
        // TODO: Handle 'error' of type FineTunesModelsLimits404Error1
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetModelLimitsRequest](Requests/FineTuning/GetModelLimitsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FineTuneModelLimits](Models/FineTuneModelLimits.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetModelLimitsError](Errors/GetModelLimitsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FinetuneTruncatedList&gt; ListAllJobs(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List the metadata for all fine-tuning jobs. Returns a list of FinetuneResponseTruncated objects.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FineTuning.ListAllJobs();
    // TODO: Handle 'response' of type FinetuneTruncatedList
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FinetuneTruncatedList](Models/FinetuneTruncatedList.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FinetuneResponse&gt; ListJob(ListJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List the metadata for a single fine-tuning job.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FineTuning.ListJob(new ListJobRequest { Id = "some example string" });
    // TODO: Handle 'response' of type FinetuneResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListJobRequest](Requests/FineTuning/ListJobRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FinetuneResponse](Models/FinetuneResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FinetuneListEvents&gt; ListJobEvents(ListJobEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List the events for a single fine-tuning job.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FineTuning.ListJobEvents(new ListJobEventsRequest { Id = "some example string" });
    // TODO: Handle 'response' of type FinetuneListEvents
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListJobEventsRequest](Requests/FineTuning/ListJobEventsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FinetuneListEvents](Models/FinetuneListEvents.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FineTunePreviewResponse&gt; PreviewTokenizedData(PreviewTokenizedDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Preview how sampled rows from a fine-tuning training file will be tokenized before packing.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FineTuning.PreviewTokenizedData(new PreviewTokenizedDataRequest
    {
        Body = new FineTunePreviewRequest { Model = "some example string", TrainingFile = "some example string" },
    });
    // TODO: Handle 'response' of type FineTunePreviewResponse
}
catch (ApiException<PreviewTokenizedDataError> ex)
{
    if (ex.Error.TryGetFineTunesPreviewResponse(out var error))
    {
        // TODO: Handle 'error' of type FineTunesPreviewResponse
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PreviewTokenizedDataRequest](Requests/FineTuning/PreviewTokenizedDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FineTunePreviewResponse](Models/FineTunePreviewResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PreviewTokenizedDataError](Errors/PreviewTokenizedDataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GpuClusterService

> Source: [GpuClusterService](Api/GpuClusterService.cs)

<details>
<summary><code>Task&lt;GpuClusterInfo&gt; GPuClusterServiceCreate(GPuClusterServiceCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an Instant Cluster on Together's high-performance GPU clusters.
With features like on-demand scaling, long-lived resizable high-bandwidth shared DC-local storage,
Kubernetes and Slurm cluster flavors, a REST API, and Terraform support,
you can run workloads flexibly without complex infrastructure management.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GpuClusterService.GPuClusterServiceCreate(new GPuClusterServiceCreateRequest
    {
        Body = new GpuClusterCreateRequest { NvidiaVersionId = "some example string" },
    });
    // TODO: Handle 'response' of type GpuClusterInfo
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GPuClusterServiceCreateRequest](Requests/GpuClusterService/GPuClusterServiceCreateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GpuClusterInfo](Models/GpuClusterInfo.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GpuClusterDeleteResponse&gt; GPuClusterServiceDelete(GPuClusterServiceDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a GPU cluster by cluster ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GpuClusterService.GPuClusterServiceDelete(new GPuClusterServiceDeleteRequest
    {
        ClusterId = "some example string",
    });
    // TODO: Handle 'response' of type GpuClusterDeleteResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GPuClusterServiceDeleteRequest](Requests/GpuClusterService/GPuClusterServiceDeleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GpuClusterDeleteResponse](Models/GpuClusterDeleteResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GpuClusterInfo&gt; GPuClusterServiceGet(GPuClusterServiceGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve information about a specific GPU cluster.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GpuClusterService.GPuClusterServiceGet(new GPuClusterServiceGetRequest
    {
        ClusterId = "some example string",
    });
    // TODO: Handle 'response' of type GpuClusterInfo
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GPuClusterServiceGetRequest](Requests/GpuClusterService/GPuClusterServiceGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GpuClusterInfo](Models/GpuClusterInfo.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GpuClusters&gt; GPuClusterServiceList(GPuClusterServiceListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all GPU clusters.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GpuClusterService.GPuClusterServiceList(new GPuClusterServiceListRequest());
    // TODO: Handle 'response' of type GpuClusters
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GPuClusterServiceListRequest](Requests/GpuClusterService/GPuClusterServiceListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GpuClusters](Models/GpuClusters.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GpuClusterInfo&gt; GPuClusterServiceUpdate(GPuClusterServiceUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the configuration of an existing GPU cluster.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GpuClusterService.GPuClusterServiceUpdate(new GPuClusterServiceUpdateRequest
    {
        ClusterId = "some example string",
        Body = new GpuClusterUpdateRequest(),
    });
    // TODO: Handle 'response' of type GpuClusterInfo
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GPuClusterServiceUpdateRequest](Requests/GpuClusterService/GPuClusterServiceUpdateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GpuClusterInfo](Models/GpuClusterInfo.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Hardware

> Source: [Hardware](Api/Hardware.cs)

<details>
<summary><code>Task&lt;HardwareResponse&gt; ListHardware(ListHardwareRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of available hardware configurations for deploying models. When a model parameter is provided, it returns only hardware configurations compatible with that model, including their current availability status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Hardware.ListHardware(new ListHardwareRequest { Model = "deepseek-ai/DeepSeek-R1" });
    // TODO: Handle 'response' of type HardwareResponse
}
catch (ApiException<ListHardwareError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListHardwareRequest](Requests/Hardware/ListHardwareRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[HardwareResponse](Models/HardwareResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ListHardwareError](Errors/ListHardwareError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## HealthCheckService

> Source: [HealthCheckService](Api/HealthCheckService.cs)

<details>
<summary><code>Task&lt;ListPassiveHealthCheckAlertsResponse&gt; HealthCheckServiceListPassiveHealthCheckAlerts(HealthCheckServiceListPassiveHealthCheckAlertsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists passive health check alerts. Filters combine across axes; empty values skip that axis.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.HealthCheckService.HealthCheckServiceListPassiveHealthCheckAlerts(
        new HealthCheckServiceListPassiveHealthCheckAlertsRequest());
    // TODO: Handle 'response' of type ListPassiveHealthCheckAlertsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[HealthCheckServiceListPassiveHealthCheckAlertsRequest](Requests/HealthCheckService/HealthCheckServiceListPassiveHealthCheckAlertsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListPassiveHealthCheckAlertsResponse](Models/ListPassiveHealthCheckAlertsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Images

> Source: [Images](Api/Images.cs)

<details>
<summary><code>Task&lt;ImageResponse&gt; CreateImage(CreateImageRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use an image model to generate an image for a given prompt.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Images.CreateImage(new CreateImageRequest
    {
        Body = new ImagesGenerationsRequest
        {
            Prompt = "some example string",
            Model = Model6.BlackForestLabsFlux1SchnellFree,
        },
    });
    // TODO: Handle 'response' of type ImageResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateImageRequest](Requests/Images/CreateImageRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ImageResponse](Models/ImageResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## InstanceClusterAddOnService

> Source: [InstanceClusterAddOnService](Api/InstanceClusterAddOnService.cs)

<details>
<summary><code>Task&lt;AddOnInfo&gt; InstanceClusterAddOnServiceCreate(InstanceClusterAddOnServiceCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstanceClusterAddOnService.InstanceClusterAddOnServiceCreate(
        new InstanceClusterAddOnServiceCreateRequest
        {
            ClusterId = "some example string",
            Body = new ClusterAddOnCreateRequest { Name = "some example string", AddOnType = "some example string" },
        });
    // TODO: Handle 'response' of type AddOnInfo
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InstanceClusterAddOnServiceCreateRequest](Requests/InstanceClusterAddOnService/InstanceClusterAddOnServiceCreateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AddOnInfo](Models/AddOnInfo.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; InstanceClusterAddOnServiceDelete(InstanceClusterAddOnServiceDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstanceClusterAddOnService.InstanceClusterAddOnServiceDelete(
        new InstanceClusterAddOnServiceDeleteRequest
        {
            ClusterId = "some example string",
            AddonId = "some example string",
        });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InstanceClusterAddOnServiceDeleteRequest](Requests/InstanceClusterAddOnService/InstanceClusterAddOnServiceDeleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AddOnInfo&gt; InstanceClusterAddOnServiceGet(InstanceClusterAddOnServiceGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstanceClusterAddOnService.InstanceClusterAddOnServiceGet(
        new InstanceClusterAddOnServiceGetRequest
        {
            ClusterId = "some example string",
            AddonId = "some example string",
        });
    // TODO: Handle 'response' of type AddOnInfo
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InstanceClusterAddOnServiceGetRequest](Requests/InstanceClusterAddOnService/InstanceClusterAddOnServiceGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AddOnInfo](Models/AddOnInfo.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ClusterAddOnsListResponse&gt; InstanceClusterAddOnServiceList(InstanceClusterAddOnServiceListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstanceClusterAddOnService.InstanceClusterAddOnServiceList(
        new InstanceClusterAddOnServiceListRequest { ClusterId = "some example string" });
    // TODO: Handle 'response' of type ClusterAddOnsListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InstanceClusterAddOnServiceListRequest](Requests/InstanceClusterAddOnService/InstanceClusterAddOnServiceListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ClusterAddOnsListResponse](Models/ClusterAddOnsListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AddOnInfo&gt; InstanceClusterAddOnServiceUpdate(InstanceClusterAddOnServiceUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstanceClusterAddOnService.InstanceClusterAddOnServiceUpdate(
        new InstanceClusterAddOnServiceUpdateRequest
        {
            ClusterId = "some example string",
            AddonId = "some example string",
            Body = new ClusterAddOnUpdateRequest(),
        });
    // TODO: Handle 'response' of type AddOnInfo
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InstanceClusterAddOnServiceUpdateRequest](Requests/InstanceClusterAddOnService/InstanceClusterAddOnServiceUpdateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AddOnInfo](Models/AddOnInfo.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## InstanceTypeService

> Source: [InstanceTypeService](Api/InstanceTypeService.cs)

<details>
<summary><code>Task&lt;DeInferenceInstanceType&gt; InstanceTypeServiceGetInferenceInstanceType(InstanceTypeServiceGetInferenceInstanceTypeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the GPU resources, pricing, regional availability, and best-effort capacity headroom for one inference instance type.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstanceTypeService.InstanceTypeServiceGetInferenceInstanceType(
        new InstanceTypeServiceGetInferenceInstanceTypeRequest { Id = "some example string" });
    // TODO: Handle 'response' of type DeInferenceInstanceType
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InstanceTypeServiceGetInferenceInstanceTypeRequest](Requests/InstanceTypeService/InstanceTypeServiceGetInferenceInstanceTypeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeInferenceInstanceType](Models/DeInferenceInstanceType.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListInferenceInstanceTypesResponse&gt; InstanceTypeServiceListInferenceInstanceTypes(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists hardware instance types currently available to inference deployments, including GPU resources, pricing, regions, and best-effort capacity headroom.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstanceTypeService.InstanceTypeServiceListInferenceInstanceTypes();
    // TODO: Handle 'response' of type DeListInferenceInstanceTypesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListInferenceInstanceTypesResponse](Models/DeListInferenceInstanceTypesResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Jobs

> Source: [Jobs](Api/Jobs.cs)

<details>
<summary><code>Task&lt;JobInfoSuccessResponse&gt; GetJob(GetJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the status of a specific job

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Jobs.GetJob(new GetJobRequest { JobId = "job-a15dad11-8d8e-4007-97c5-a211304de284" });
    // TODO: Handle 'response' of type JobInfoSuccessResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetJobRequest](Requests/Jobs/GetJobRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[JobInfoSuccessResponse](Models/JobInfoSuccessResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;JobsInfoSuccessResponse&gt; ListJobs(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all jobs and their statuses

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Jobs.ListJobs();
    // TODO: Handle 'response' of type JobsInfoSuccessResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[JobsInfoSuccessResponse](Models/JobsInfoSuccessResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ModelsApi

> Source: [ModelsApi](Api/ModelsApi.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ModelInfo&gt;&gt; Models(ModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all of Together's open-source models and metadata including pricing, chat template, and context.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ModelsApi.Models(new ModelsRequest());
    // TODO: Handle 'response' of type IReadOnlyList<ModelInfo>
}
catch (ApiException<ModelsError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ModelsRequest](Requests/ModelsApi/ModelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ModelInfo](Models/ModelInfo.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ModelsError](Errors/ModelsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModelUploadSuccessResponse&gt; UploadModel(UploadModelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Upload a custom model or adapter from Hugging Face or S3

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ModelsApi.UploadModel(new UploadModelRequest
    {
        Body = new ModelUploadRequest { ModelName = "some example string", ModelSource = "some example string" },
    });
    // TODO: Handle 'response' of type ModelUploadSuccessResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UploadModelRequest](Requests/ModelsApi/UploadModelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModelUploadSuccessResponse](Models/ModelUploadSuccessResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PlacementProfileService

> Source: [PlacementProfileService](Api/PlacementProfileService.cs)

<details>
<summary><code>Task&lt;DePlacementProfile&gt; PlacementProfileServiceGetPlacementProfile(PlacementProfileServiceGetPlacementProfileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a reusable placement profile and its ordered region preferences.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PlacementProfileService.PlacementProfileServiceGetPlacementProfile(
        new PlacementProfileServiceGetPlacementProfileRequest
        {
            ProjectId = "some example string",
            Id = "some example string",
        });
    // TODO: Handle 'response' of type DePlacementProfile
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PlacementProfileServiceGetPlacementProfileRequest](Requests/PlacementProfileService/PlacementProfileServiceGetPlacementProfileRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DePlacementProfile](Models/DePlacementProfile.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListPlacementProfilesResponse&gt; PlacementProfileServiceListPlacementProfiles(PlacementProfileServiceListPlacementProfilesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists reusable, project-visible placement policies that control the regions where deployments may be scheduled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PlacementProfileService.PlacementProfileServiceListPlacementProfiles(
        new PlacementProfileServiceListPlacementProfilesRequest { ProjectId = "some example string" });
    // TODO: Handle 'response' of type DeListPlacementProfilesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PlacementProfileServiceListPlacementProfilesRequest](Requests/PlacementProfileService/PlacementProfileServiceListPlacementProfilesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListPlacementProfilesResponse](Models/DeListPlacementProfilesResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## QueueApi

> Source: [QueueApi](Api/QueueApi.cs)

<details>
<summary><code>Task&lt;QueueCancelResponse&gt; CancelQueueJob(CancelQueueJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel a pending job. Only jobs in pending status can be canceled.
Running jobs cannot be stopped. Returns the job status after the
attempt. If the job is not pending, returns 409 with the current status
unchanged.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.QueueApi.CancelQueueJob(new CancelQueueJobRequest
    {
        Body = new QueueCancelRequest { Model = "some example string", RequestId = "some example string" },
    });
    // TODO: Handle 'response' of type QueueCancelResponse
}
catch (ApiException<CancelQueueJobError> ex)
{
    if (ex.Error.TryGetQueueError(out var error))
    {
        // TODO: Handle 'error' of type QueueError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelQueueJobRequest](Requests/QueueApi/CancelQueueJobRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[QueueCancelResponse](Models/QueueCancelResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CancelQueueJobError](Errors/CancelQueueJobError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;QueueClearResponse&gt; ClearQueue(ClearQueueRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel all pending jobs for the given model. Running jobs are left untouched. Returns the number of jobs that were canceled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.QueueApi.ClearQueue(new ClearQueueRequest
    {
        Body = new QueueClearRequest { Model = "some example string" },
    });
    // TODO: Handle 'response' of type QueueClearResponse
}
catch (ApiException<ClearQueueError> ex)
{
    if (ex.Error.TryGetQueueError(out var error))
    {
        // TODO: Handle 'error' of type QueueError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ClearQueueRequest](Requests/QueueApi/ClearQueueRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[QueueClearResponse](Models/QueueClearResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ClearQueueError](Errors/ClearQueueError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;QueueJobStatusResponse&gt; GetQueueJobStatus(GetQueueJobStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Poll the current status of a previously submitted job. Provide the request_id and model as query parameters.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.QueueApi.GetQueueJobStatus(new GetQueueJobStatusRequest
    {
        RequestId = "some example string",
        Model = "some example string",
    });
    // TODO: Handle 'response' of type QueueJobStatusResponse
}
catch (ApiException<GetQueueJobStatusError> ex)
{
    if (ex.Error.TryGetQueueError(out var error))
    {
        // TODO: Handle 'error' of type QueueError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetQueueJobStatusRequest](Requests/QueueApi/GetQueueJobStatusRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[QueueJobStatusResponse](Models/QueueJobStatusResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetQueueJobStatusError](Errors/GetQueueJobStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;QueueMetricsResponse&gt; GetQueueMetrics(GetQueueMetricsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the current queue statistics for a model, including pending and running job counts.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.QueueApi.GetQueueMetrics(new GetQueueMetricsRequest { Model = "some example string" });
    // TODO: Handle 'response' of type QueueMetricsResponse
}
catch (ApiException<GetQueueMetricsError> ex)
{
    if (ex.Error.TryGetQueueError(out var error))
    {
        // TODO: Handle 'error' of type QueueError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetQueueMetricsRequest](Requests/QueueApi/GetQueueMetricsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[QueueMetricsResponse](Models/QueueMetricsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetQueueMetricsError](Errors/GetQueueMetricsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;QueueJobResponse&gt; SubmitQueueJob(SubmitQueueJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Submit a new job to the queue for asynchronous processing. Jobs are
processed in strict priority order (higher priority first, FIFO within
the same priority). Returns a request ID that can be used to poll status
or cancel the job.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.QueueApi.SubmitQueueJob(new SubmitQueueJobRequest
    {
        Body = new QueueJobRequest { Model = "some example string", Payload = payload },
    });
    // TODO: Handle 'response' of type QueueJobResponse
}
catch (ApiException<SubmitQueueJobError> ex)
{
    if (ex.Error.TryGetQueueError(out var error))
    {
        // TODO: Handle 'error' of type QueueError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SubmitQueueJobRequest](Requests/QueueApi/SubmitQueueJobRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[QueueJobResponse](Models/QueueJobResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SubmitQueueJobError](Errors/SubmitQueueJobError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Rl

> Source: [Rl](Api/Rl.cs)

<details>
<summary><code>Task&lt;RlSampleOperation&gt; GetSample(GetSampleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the current status and result of a sample operation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.GetSample(new GetSampleRequest
    {
        SessionId = "some example string",
        OperationId = "some example string",
    });
    // TODO: Handle 'response' of type RlSampleOperation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSampleRequest](Requests/Rl/GetSampleRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlSampleOperation](Models/RlSampleOperation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlOptimStepOperation&gt; OptimStep(OptimStepRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Submits an optimizer step operation that will asynchronously apply accumulated gradients to update model parameters. Does not make the updated parameters available for sampling; call `weights-sync` afterwards when you want subsequent samples to use the updated policy.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.OptimStep(new OptimStepRequest
    {
        SessionId = "some example string",
        IdempotencyKey = "some example string",
        Body = new RlOptimStepBody(),
    });
    // TODO: Handle 'response' of type RlOptimStepOperation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OptimStepRequest](Requests/Rl/OptimStepRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlOptimStepOperation](Models/RlOptimStepOperation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlSampleOperation&gt; Sample(SampleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Submits a sample operation that will asynchronously generate text completions with logprobs.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.Sample(new SampleRequest
    {
        SessionId = "some example string",
        IdempotencyKey = "some example string",
        Body = new RlSampleBody
        {
            ModelInputs = [
                new RlModelInput
                {
                    Chunks = [new RlModelInputChunk { EncodedText = new RlEncodedTextChunk2 { Tokens = tokens } }],
                },
            ],
        },
    });
    // TODO: Handle 'response' of type RlSampleOperation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SampleRequest](Requests/Rl/SampleRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlSampleOperation](Models/RlSampleOperation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlWeightsSyncOperation&gt; WeightsSync(WeightsSyncRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Submits a weights-sync operation that makes the session's current trained parameters available for sampling. Call this after `optim-step` when you want subsequent samples to use the updated policy.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.WeightsSync(new WeightsSyncRequest
    {
        SessionId = "some example string",
        IdempotencyKey = "some example string",
        Body = new RlWeightsSyncBody { WeightSyncType = RlWeightSyncType2.WeightSyncTypeSynchronous },
    });
    // TODO: Handle 'response' of type RlWeightsSyncOperation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WeightsSyncRequest](Requests/Rl/WeightsSyncRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlWeightsSyncOperation](Models/RlWeightsSyncOperation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlInferenceCheckpointOperation&gt; CreateInferenceCheckpoint(CreateInferenceCheckpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Submits an operation that will asynchronously save the current LoRA adapter as an inference checkpoint and upload it to object storage.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.CreateInferenceCheckpoint(new CreateInferenceCheckpointRequest
    {
        SessionId = "some example string",
        IdempotencyKey = "some example string",
    });
    // TODO: Handle 'response' of type RlInferenceCheckpointOperation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateInferenceCheckpointRequest](Requests/Rl/CreateInferenceCheckpointRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlInferenceCheckpointOperation](Models/RlInferenceCheckpointOperation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlModelResources&gt; CreateModelResources(CreateModelResourcesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provisions a standalone model resource that training sessions can attach to.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.CreateModelResources(new CreateModelResourcesRequest
    {
        Body = new RlCreateModelResourcesRequest { BaseModel = "some example string" },
    });
    // TODO: Handle 'response' of type RlModelResources
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateModelResourcesRequest](Requests/Rl/CreateModelResourcesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlModelResources](Models/RlModelResources.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlTrainingCheckpointOperation&gt; CreateTrainingCheckpoint(CreateTrainingCheckpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Submits an operation that will asynchronously save the full training state (adapter + optimizer + step).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.CreateTrainingCheckpoint(new CreateTrainingCheckpointRequest
    {
        SessionId = "some example string",
        IdempotencyKey = "some example string",
    });
    // TODO: Handle 'response' of type RlTrainingCheckpointOperation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateTrainingCheckpointRequest](Requests/Rl/CreateTrainingCheckpointRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlTrainingCheckpointOperation](Models/RlTrainingCheckpointOperation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlCustomForwardBackwardOperation&gt; CustomForwardBackward(CustomForwardBackwardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Submits a forward-backward pass driven by externally computed gradients of the loss with respect to per-token log-probabilities.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.CustomForwardBackward(new CustomForwardBackwardRequest
    {
        SessionId = "some example string",
        IdempotencyKey = "some example string",
        Body = new RlCustomForwardBackwardBody
        {
            Samples = [
                new RlTrainingSample
                {
                    ModelInput = new RlModelInput1 { Chunks = [new RlModelInputChunk { EncodedText = encodedText }] },
                    LossFnInputs = new Dictionary<string, RlTensorData>
                    {
                        ["key"] = new RlTensorData { Data = [1.5d], Dtype = Dtype.Int64 },
                    },
                },
            ],
            Gradients = [new RlTargetLogprobGradients { Data = [1.5d] }],
        },
    });
    // TODO: Handle 'response' of type RlCustomForwardBackwardOperation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CustomForwardBackwardRequest](Requests/Rl/CustomForwardBackwardRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlCustomForwardBackwardOperation](Models/RlCustomForwardBackwardOperation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlCheckpointDownloadResponse&gt; DownloadCheckpoint(DownloadCheckpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns presigned URLs for downloading a checkpoint's model files. Only inference checkpoints support downloading.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.DownloadCheckpoint(new DownloadCheckpointRequest
    {
        Id = "some example string",
        Variant = RlCheckpointVariant1.CheckpointVariantUnspecified,
    });
    // TODO: Handle 'response' of type RlCheckpointDownloadResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DownloadCheckpointRequest](Requests/Rl/DownloadCheckpointRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlCheckpointDownloadResponse](Models/RlCheckpointDownloadResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlModelResourcesEstimateCostResponse&gt; EstimateModelResourcesCost(EstimateModelResourcesCostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Estimates a model resource's on-demand hourly price without creating it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.EstimateModelResourcesCost(new EstimateModelResourcesCostRequest
    {
        Body = new RlCreateModelResourcesRequest { BaseModel = "some example string" },
    });
    // TODO: Handle 'response' of type RlModelResourcesEstimateCostResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EstimateModelResourcesCostRequest](Requests/Rl/EstimateModelResourcesCostRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlModelResourcesEstimateCostResponse](Models/RlModelResourcesEstimateCostResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlForwardBackwardOperation&gt; ForwardBackward(ForwardBackwardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Submits a forward-backward pass operation that will asynchronously compute gradients via backpropagation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.ForwardBackward(new ForwardBackwardRequest
    {
        SessionId = "some example string",
        IdempotencyKey = "some example string",
        Body = new RlForwardBackwardBody
        {
            Samples = [
                new RlTrainingSample
                {
                    ModelInput = new RlModelInput1 { Chunks = [new RlModelInputChunk { EncodedText = encodedText }] },
                    LossFnInputs = new Dictionary<string, RlTensorData>
                    {
                        ["key"] = new RlTensorData { Data = [1.5d], Dtype = Dtype.Int64 },
                    },
                },
            ],
            Loss = new RlLossConfig2 { Type = RlLossType2.LossTypeUnspecified },
        },
    });
    // TODO: Handle 'response' of type RlForwardBackwardOperation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ForwardBackwardRequest](Requests/Rl/ForwardBackwardRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlForwardBackwardOperation](Models/RlForwardBackwardOperation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlCheckpoint&gt; GetCheckpoint(GetCheckpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns metadata for a checkpoint: type, base model, LoRA rank, step, and owning session.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.GetCheckpoint(new GetCheckpointRequest { Id = "some example string" });
    // TODO: Handle 'response' of type RlCheckpoint
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCheckpointRequest](Requests/Rl/GetCheckpointRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlCheckpoint](Models/RlCheckpoint.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlCustomForwardBackwardOperation&gt; GetCustomForwardBackwardOperation(GetCustomForwardBackwardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the current status and result of a custom forward-backward operation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.GetCustomForwardBackwardOperation(new GetCustomForwardBackwardOperationRequest
    {
        SessionId = "some example string",
        OperationId = "some example string",
    });
    // TODO: Handle 'response' of type RlCustomForwardBackwardOperation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCustomForwardBackwardOperationRequest](Requests/Rl/GetCustomForwardBackwardOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlCustomForwardBackwardOperation](Models/RlCustomForwardBackwardOperation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlForwardBackwardOperation&gt; GetForwardBackwardOperation(GetForwardBackwardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the current status and result of a forward-backward operation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.GetForwardBackwardOperation(new GetForwardBackwardOperationRequest
    {
        SessionId = "some example string",
        OperationId = "some example string",
    });
    // TODO: Handle 'response' of type RlForwardBackwardOperation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetForwardBackwardOperationRequest](Requests/Rl/GetForwardBackwardOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlForwardBackwardOperation](Models/RlForwardBackwardOperation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlInferenceCheckpointOperation&gt; GetInferenceCheckpointOperation(GetInferenceCheckpointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the current status and result of an inference checkpoint operation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.GetInferenceCheckpointOperation(new GetInferenceCheckpointOperationRequest
    {
        SessionId = "some example string",
        OperationId = "some example string",
    });
    // TODO: Handle 'response' of type RlInferenceCheckpointOperation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetInferenceCheckpointOperationRequest](Requests/Rl/GetInferenceCheckpointOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlInferenceCheckpointOperation](Models/RlInferenceCheckpointOperation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlModelResources&gt; GetModelResources(GetModelResourcesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets a model resource by its ID and returns its details.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.GetModelResources(new GetModelResourcesRequest
    {
        ModelResourcesId = "some example string",
    });
    // TODO: Handle 'response' of type RlModelResources
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetModelResourcesRequest](Requests/Rl/GetModelResourcesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlModelResources](Models/RlModelResources.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlOptimStepOperation&gt; GetOptimStepOperation(GetOptimStepOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the current status and result of an optim-step operation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.GetOptimStepOperation(new GetOptimStepOperationRequest
    {
        SessionId = "some example string",
        OperationId = "some example string",
    });
    // TODO: Handle 'response' of type RlOptimStepOperation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetOptimStepOperationRequest](Requests/Rl/GetOptimStepOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlOptimStepOperation](Models/RlOptimStepOperation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlTrainingCheckpointOperation&gt; GetTrainingCheckpointOperation(GetTrainingCheckpointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the current status and result of a save training checkpoint operation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.GetTrainingCheckpointOperation(new GetTrainingCheckpointOperationRequest
    {
        SessionId = "some example string",
        OperationId = "some example string",
    });
    // TODO: Handle 'response' of type RlTrainingCheckpointOperation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTrainingCheckpointOperationRequest](Requests/Rl/GetTrainingCheckpointOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlTrainingCheckpointOperation](Models/RlTrainingCheckpointOperation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlTrainingSession&gt; GetTrainingSession(GetTrainingSessionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Gets a training session by its ID and returns its details.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.GetTrainingSession(new GetTrainingSessionRequest
    {
        SessionId = "some example string",
    });
    // TODO: Handle 'response' of type RlTrainingSession
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetTrainingSessionRequest](Requests/Rl/GetTrainingSessionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlTrainingSession](Models/RlTrainingSession.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlWeightsSyncOperation&gt; GetWeightsSyncOperation(GetWeightsSyncOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the current status and result of a weights-sync operation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.GetWeightsSyncOperation(new GetWeightsSyncOperationRequest
    {
        SessionId = "some example string",
        OperationId = "some example string",
    });
    // TODO: Handle 'response' of type RlWeightsSyncOperation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetWeightsSyncOperationRequest](Requests/Rl/GetWeightsSyncOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlWeightsSyncOperation](Models/RlWeightsSyncOperation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlCheckpointsListResponse&gt; ListCheckpoints(ListCheckpointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists training checkpoints owned by the caller. Filter by session or base model to recover a checkpoint ID for resume. Inference checkpoints are not included; they remain on the training session and in the model catalog.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.ListCheckpoints(new ListCheckpointsRequest());
    // TODO: Handle 'response' of type RlCheckpointsListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCheckpointsRequest](Requests/Rl/ListCheckpointsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlCheckpointsListResponse](Models/RlCheckpointsListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlModelResourcesListResponse&gt; ListModelResources(ListModelResourcesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the caller's model resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.ListModelResources(new ListModelResourcesRequest());
    // TODO: Handle 'response' of type RlModelResourcesListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListModelResourcesRequest](Requests/Rl/ListModelResourcesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlModelResourcesListResponse](Models/RlModelResourcesListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlSupportedModelsListResponse&gt; ListSupportedModels(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the models supported by the RL service and their limits for training/sampling operations.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.ListSupportedModels();
    // TODO: Handle 'response' of type RlSupportedModelsListResponse
}
catch (ApiException<ListSupportedModelsError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlSupportedModelsListResponse](Models/RlSupportedModelsListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ListSupportedModelsError](Errors/ListSupportedModelsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlTrainingSessionsListResponse&gt; ListTrainingSessions(ListTrainingSessionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists all training sessions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.ListTrainingSessions(new ListTrainingSessionsRequest());
    // TODO: Handle 'response' of type RlTrainingSessionsListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListTrainingSessionsRequest](Requests/Rl/ListTrainingSessionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlTrainingSessionsListResponse](Models/RlTrainingSessionsListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlTrainingSession&gt; StartTrainingSession(StartTrainingSessionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a training session and returns its details.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.StartTrainingSession(new StartTrainingSessionRequest
    {
        Body = new RlStartTrainingSessionRequest { ModelResourcesId = "some example string" },
    });
    // TODO: Handle 'response' of type RlTrainingSession
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StartTrainingSessionRequest](Requests/Rl/StartTrainingSessionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlTrainingSession](Models/RlTrainingSession.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlModelResources&gt; StopModelResources(StopModelResourcesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Stops the model resource and releases its allocated compute. If active training sessions are attached, the request fails unless `force=true`. A forced stop also stops all attached training sessions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.StopModelResources(new StopModelResourcesRequest
    {
        ModelResourcesId = "some example string",
    });
    // TODO: Handle 'response' of type RlModelResources
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StopModelResourcesRequest](Requests/Rl/StopModelResourcesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlModelResources](Models/RlModelResources.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlTrainingSession&gt; StopTrainingSession(StopTrainingSessionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Stops a training session.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.StopTrainingSession(new StopTrainingSessionRequest
    {
        SessionId = "some example string",
    });
    // TODO: Handle 'response' of type RlTrainingSession
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StopTrainingSessionRequest](Requests/Rl/StopTrainingSessionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlTrainingSession](Models/RlTrainingSession.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RlTrainingSession&gt; UpdateTrainingSession(UpdateTrainingSessionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the display name or metadata associated with a training session. Omitted fields remain unchanged, and empty strings clear existing values.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rl.UpdateTrainingSession(new UpdateTrainingSessionRequest
    {
        SessionId = "some example string",
        Body = new RlUpdateTrainingSessionRequest(),
    });
    // TODO: Handle 'response' of type RlTrainingSession
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateTrainingSessionRequest](Requests/Rl/UpdateTrainingSessionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RlTrainingSession](Models/RlTrainingSession.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RegionService

> Source: [RegionService](Api/RegionService.cs)

<details>
<summary><code>Task&lt;RegionListResponse&gt; RegionServiceList(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RegionService.RegionServiceList();
    // TODO: Handle 'response' of type RegionListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RegionListResponse](Models/RegionListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RemediationService

> Source: [RemediationService](Api/RemediationService.cs)

<details>
<summary><code>Task&lt;Remediation&gt; RemediationServiceApproveRemediation(RemediationServiceApproveRemediationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Approves a pending remediation.

Only remediations with state PENDING_APPROVAL can be approved.

On APPROVE: state changes to PENDING and the remediation process begins.
The reviewed_by, review_time, and review_comment fields are populated
on the remediation after approval.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RemediationService.RemediationServiceApproveRemediation(
        new RemediationServiceApproveRemediationRequest
        {
            ClusterId = "some example string",
            InstanceId = "some example string",
            RemediationId = "some example string",
            Body = new ApproveRemediationRequest(),
        });
    // TODO: Handle 'response' of type Remediation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemediationServiceApproveRemediationRequest](Requests/RemediationService/RemediationServiceApproveRemediationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Remediation](Models/Remediation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Remediation&gt; RemediationServiceCancelRemediation(RemediationServiceCancelRemediationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels a pending remediation.

Only remediations in PENDING_APPROVAL or PENDING state can be cancelled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RemediationService.RemediationServiceCancelRemediation(
        new RemediationServiceCancelRemediationRequest
        {
            ClusterId = "some example string",
            InstanceId = "some example string",
            RemediationId = "some example string",
        });
    // TODO: Handle 'response' of type Remediation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemediationServiceCancelRemediationRequest](Requests/RemediationService/RemediationServiceCancelRemediationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Remediation](Models/Remediation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Remediation&gt; RemediationServiceCreateRemediation(RemediationServiceCreateRemediationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new remediation for an instance.

Remediations created via the API goes directly to PENDING state.

Our system may trigger automated remediations that require approval. These remediations are created with PENDING_APPROVAL state.
The user must call /approve to start the actual remediation process.
These operations can also be rejected by calling /reject.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RemediationService.RemediationServiceCreateRemediation(
        new RemediationServiceCreateRemediationRequest
        {
            ClusterId = "some example string",
            InstanceId = "some example string",
            Body = new Remediation
            {
                Id = "some example string",
                ClusterId = "some example string",
                InstanceId = "some example string",
                Mode = Mode.RemediationModeVmOnly,
                Trigger = Trigger.RemediationTriggerManual,
                State = State6.PendingApproval,
            },
        });
    // TODO: Handle 'response' of type Remediation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemediationServiceCreateRemediationRequest](Requests/RemediationService/RemediationServiceCreateRemediationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Remediation](Models/Remediation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Remediation&gt; RemediationServiceGetRemediation(RemediationServiceGetRemediationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve the status of a specific remdiation on a specific instance in a specific cluster.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RemediationService.RemediationServiceGetRemediation(
        new RemediationServiceGetRemediationRequest
        {
            ClusterId = "some example string",
            InstanceId = "some example string",
            RemediationId = "some example string",
        });
    // TODO: Handle 'response' of type Remediation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemediationServiceGetRemediationRequest](Requests/RemediationService/RemediationServiceGetRemediationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Remediation](Models/Remediation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListRemediationsResponse&gt; RemediationServiceListRemediations(RemediationServiceListRemediationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists remediations for an instance or cluster.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RemediationService.RemediationServiceListRemediations(
        new RemediationServiceListRemediationsRequest
        {
            ClusterId = "some example string",
            InstanceId = "some example string",
        });
    // TODO: Handle 'response' of type ListRemediationsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemediationServiceListRemediationsRequest](Requests/RemediationService/RemediationServiceListRemediationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListRemediationsResponse](Models/ListRemediationsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Remediation&gt; RemediationServiceRejectRemediation(RemediationServiceRejectRemediationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Rejects a pending remediation.

Only remediations with state PENDING_APPROVAL can be rejected.

On REJECT: state changes to CANCELLED.
The reviewed_by, review_time, and review_comment fields are populated
on the remediation after rejection.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RemediationService.RemediationServiceRejectRemediation(
        new RemediationServiceRejectRemediationRequest
        {
            ClusterId = "some example string",
            InstanceId = "some example string",
            RemediationId = "some example string",
            Body = new CommentBody(),
        });
    // TODO: Handle 'response' of type Remediation
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemediationServiceRejectRemediationRequest](Requests/RemediationService/RemediationServiceRejectRemediationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Remediation](Models/Remediation.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Rerank

> Source: [Rerank](Api/Rerank.cs)

<details>
<summary><code>Task&lt;RerankResponse&gt; RerankInvoke(RerankOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Rerank a list of documents by relevance to a query. Returns a relevance score and ordering index for each document.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Rerank.RerankInvoke(new RerankOperationRequest());
    // TODO: Handle 'response' of type RerankResponse
}
catch (ApiException<RerankError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RerankOperationRequest](Requests/Rerank/RerankOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RerankResponse](Models/RerankResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RerankError](Errors/RerankError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RolloutService

> Source: [RolloutService](Api/RolloutService.cs)

<details>
<summary><code>Task&lt;DeRollout&gt; RolloutServiceCancelRollout(RolloutServiceCancelRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels a running, pausing, paused, system-paused, or stabilizing rollout by freezing the current traffic split into standing weights. Revert is removed and rejected; after canceling, start another canary rollout in either direction or rebalance the traffic split. The response is the accepted rollout snapshot; poll GetRollout until it reaches CANCELED.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RolloutService.RolloutServiceCancelRollout(new RolloutServiceCancelRolloutRequest
    {
        ProjectId = "some example string",
        EndpointId = "some example string",
        Id = "some example string",
        Body = new DeCancelRolloutRequest { Reason = "some example string" },
    });
    // TODO: Handle 'response' of type DeRollout
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RolloutServiceCancelRolloutRequest](Requests/RolloutService/RolloutServiceCancelRolloutRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeRollout](Models/DeRollout.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeRollout&gt; RolloutServiceCreateRollout(RolloutServiceCreateRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a rollout in the pending state without shifting traffic. Start the rollout in a separate request after reviewing its strategy and metric gates.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RolloutService.RolloutServiceCreateRollout(new RolloutServiceCreateRolloutRequest
    {
        ProjectId = "some example string",
        EndpointId = "some example string",
        Body = new DeCreateRolloutRequest
        {
            SourceDeploymentId = "dep_source123",
            TargetDeploymentId = "dep_target456",
            Canary = new DeCanaryConfig
            {
                Steps = [
                    new DeRolloutStep { Traffic = 25 },
                    new DeRolloutStep { Traffic = 50 },
                    new DeRolloutStep { Traffic = 100 },
                ],
                StepInterval = "300s",
            },
            Metrics = [
                new DeMetricRule
                {
                    Name = Name1.RouterLatency,
                    Stat = Stat1.MetricStatTypePercentile,
                    Percentile = 95,
                    ThresholdCheck = new DeThresholdCheck { Value = 30000d, Operator = Operator1.ThresholdOperatorLt },
                    Window = "300s",
                },
            ],
        },
    });
    // TODO: Handle 'response' of type DeRollout
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RolloutServiceCreateRolloutRequest](Requests/RolloutService/RolloutServiceCreateRolloutRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeRollout](Models/DeRollout.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; RolloutServiceDeleteRollout(RolloutServiceDeleteRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a rollout record. An active rollout must be aborted or completed before it can be deleted.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RolloutService.RolloutServiceDeleteRollout(new RolloutServiceDeleteRolloutRequest
    {
        ProjectId = "some example string",
        EndpointId = "some example string",
        Id = "some example string",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RolloutServiceDeleteRolloutRequest](Requests/RolloutService/RolloutServiceDeleteRolloutRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeRollout&gt; RolloutServiceGetRollout(RolloutServiceGetRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a rollout's strategy, lifecycle state, current traffic percentage, step history, and metric-gate results.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RolloutService.RolloutServiceGetRollout(new RolloutServiceGetRolloutRequest
    {
        ProjectId = "some example string",
        EndpointId = "some example string",
        Id = "some example string",
    });
    // TODO: Handle 'response' of type DeRollout
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RolloutServiceGetRolloutRequest](Requests/RolloutService/RolloutServiceGetRolloutRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeRollout](Models/DeRollout.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListRolloutsResponse&gt; RolloutServiceListRollouts(RolloutServiceListRolloutsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists rollout histories for an endpoint. Use `filter=ROLLOUT_FILTER_ACTIVE` to return only the active rollout, if one exists.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RolloutService.RolloutServiceListRollouts(new RolloutServiceListRolloutsRequest
    {
        ProjectId = "some example string",
        EndpointId = "some example string",
    });
    // TODO: Handle 'response' of type DeListRolloutsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RolloutServiceListRolloutsRequest](Requests/RolloutService/RolloutServiceListRolloutsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListRolloutsResponse](Models/DeListRolloutsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeRollout&gt; RolloutServicePauseRollout(RolloutServicePauseRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Requests a running or stabilizing rollout to pause and records an optional reason. The response returns the PAUSING snapshot; poll GetRollout until state is PAUSED to confirm the executor has parked.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RolloutService.RolloutServicePauseRollout(new RolloutServicePauseRolloutRequest
    {
        ProjectId = "some example string",
        EndpointId = "some example string",
        Id = "some example string",
        Body = new DePauseRolloutRequest(),
    });
    // TODO: Handle 'response' of type DeRollout
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RolloutServicePauseRolloutRequest](Requests/RolloutService/RolloutServicePauseRolloutRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeRollout](Models/DeRollout.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeRolloutDefaultsPreview&gt; RolloutServicePreviewRolloutDefaults(RolloutServicePreviewRolloutDefaultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the values a create request would pick for any field left unset, plus the capacity context needed to display them, without creating a rollout. Responses are display state only and re-validated authoritatively at create and start; do not copy response values back into a create request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RolloutService.RolloutServicePreviewRolloutDefaults(
        new RolloutServicePreviewRolloutDefaultsRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            Body = new DeCreateRolloutRequest
            {
                SourceDeploymentId = "dep_source123",
                TargetDeploymentId = "dep_target456",
                Canary = new DeCanaryConfig
                {
                    Steps = [
                        new DeRolloutStep { Traffic = 25 },
                        new DeRolloutStep { Traffic = 50 },
                        new DeRolloutStep { Traffic = 100 },
                    ],
                    StepInterval = "300s",
                },
                Metrics = [
                    new DeMetricRule
                    {
                        Name = Name1.RouterLatency,
                        Stat = Stat1.MetricStatTypePercentile,
                        Percentile = 95,
                        ThresholdCheck = new DeThresholdCheck
                        {
                            Value = 30000d,
                            Operator = Operator1.ThresholdOperatorLt,
                        },
                        Window = "300s",
                    },
                ],
            },
        });
    // TODO: Handle 'response' of type DeRolloutDefaultsPreview
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RolloutServicePreviewRolloutDefaultsRequest](Requests/RolloutService/RolloutServicePreviewRolloutDefaultsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeRolloutDefaultsPreview](Models/DeRolloutDefaultsPreview.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeRollout&gt; RolloutServicePromoteRollout(RolloutServicePromoteRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Completes a running or paused rollout immediately by sending all live traffic to the target deployment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RolloutService.RolloutServicePromoteRollout(new RolloutServicePromoteRolloutRequest
    {
        ProjectId = "some example string",
        EndpointId = "some example string",
        Id = "some example string",
        Body = new DePromoteRolloutRequest(),
    });
    // TODO: Handle 'response' of type DeRollout
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RolloutServicePromoteRolloutRequest](Requests/RolloutService/RolloutServicePromoteRolloutRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeRollout](Models/DeRollout.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeRollout&gt; RolloutServiceResumeRollout(RolloutServiceResumeRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Resumes a pausing, paused, or system-paused rollout from its current step and traffic split.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RolloutService.RolloutServiceResumeRollout(new RolloutServiceResumeRolloutRequest
    {
        ProjectId = "some example string",
        EndpointId = "some example string",
        Id = "some example string",
        Body = new DeResumeRolloutRequest(),
    });
    // TODO: Handle 'response' of type DeRollout
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RolloutServiceResumeRolloutRequest](Requests/RolloutService/RolloutServiceResumeRolloutRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeRollout](Models/DeRollout.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeRollout&gt; RolloutServiceStartRollout(RolloutServiceStartRolloutRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Starts a pending rollout and begins its configured traffic-shifting workflow.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RolloutService.RolloutServiceStartRollout(new RolloutServiceStartRolloutRequest
    {
        ProjectId = "some example string",
        EndpointId = "some example string",
        Id = "some example string",
    });
    // TODO: Handle 'response' of type DeRollout
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RolloutServiceStartRolloutRequest](Requests/RolloutService/RolloutServiceStartRolloutRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeRollout](Models/DeRollout.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Secrets

> Source: [Secrets](Api/Secrets.cs)

<details>
<summary><code>Task&lt;SecretResponseItem&gt; CreateANewSecret(CreateANewSecretRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new secret to store sensitive configuration values

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Secrets.CreateANewSecret(new CreateANewSecretRequest
    {
        Body = new CreateSecretRequest { Name = "some example string", Value = "some example string" },
    });
    // TODO: Handle 'response' of type SecretResponseItem
}
catch (ApiException<CreateANewSecretError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateANewSecretRequest](Requests/Secrets/CreateANewSecretRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SecretResponseItem](Models/SecretResponseItem.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreateANewSecretError](Errors/CreateANewSecretError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; DeleteASecret(DeleteASecretRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an existing secret

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Secrets.DeleteASecret(new DeleteASecretRequest { Id = "some example string" });
    // TODO: Handle 'response' of type object
}
catch (ApiException<DeleteASecretError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteASecretRequest](Requests/Secrets/DeleteASecretRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteASecretError](Errors/DeleteASecretError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SecretResponseItem&gt; GetASecretByIdOrName(GetASecretByIdOrNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve details of a specific secret by its ID or name

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Secrets.GetASecretByIdOrName(new GetASecretByIdOrNameRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type SecretResponseItem
}
catch (ApiException<GetASecretByIdOrNameError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetASecretByIdOrNameRequest](Requests/Secrets/GetASecretByIdOrNameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SecretResponseItem](Models/SecretResponseItem.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetASecretByIdOrNameError](Errors/GetASecretByIdOrNameError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ListSecretsResponse&gt; GetTheListOfProjectSecrets(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve all secrets in your project

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Secrets.GetTheListOfProjectSecrets();
    // TODO: Handle 'response' of type ListSecretsResponse
}
catch (ApiException<GetTheListOfProjectSecretsError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListSecretsResponse](Models/ListSecretsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetTheListOfProjectSecretsError](Errors/GetTheListOfProjectSecretsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SecretResponseItem&gt; UpdateASecret(UpdateASecretRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an existing secret's value or metadata

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Secrets.UpdateASecret(new UpdateASecretRequest
    {
        Id = "some example string",
        Body = new UpdateSecretRequest(),
    });
    // TODO: Handle 'response' of type SecretResponseItem
}
catch (ApiException<UpdateASecretError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateASecretRequest](Requests/Secrets/UpdateASecretRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SecretResponseItem](Models/SecretResponseItem.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UpdateASecretError](Errors/UpdateASecretError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ShadowExperimentService

> Source: [ShadowExperimentService](Api/ShadowExperimentService.cs)

<details>
<summary><code>Task&lt;DeShadowExperiment&gt; ShadowExperimentServiceCreateShadowExperiment(ShadowExperimentServiceCreateShadowExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an experiment that mirrors a sampled portion of endpoint traffic to one or more target deployments without returning their responses to clients. Add a description with the update operation after creation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShadowExperimentService.ShadowExperimentServiceCreateShadowExperiment(
        new ShadowExperimentServiceCreateShadowExperimentRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            Body = new DeCreateShadowExperimentRequest
            {
                Name = "some example string",
                Source = new DeShadowExperimentSource
                {
                    Endpoint = new DeShadowExperimentEndpointSource
                    {
                        Sampling = new DeShadowExperimentSampling { Uniform = uniform },
                    },
                },
            },
        });
    // TODO: Handle 'response' of type DeShadowExperiment
}
catch (ApiException<ShadowExperimentServiceCreateShadowExperimentError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ShadowExperimentServiceCreateShadowExperimentRequest](Requests/ShadowExperimentService/ShadowExperimentServiceCreateShadowExperimentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeShadowExperiment](Models/DeShadowExperiment.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ShadowExperimentServiceCreateShadowExperimentError](Errors/ShadowExperimentServiceCreateShadowExperimentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeShadowExperimentTarget&gt; ShadowExperimentServiceCreateTarget(ShadowExperimentServiceCreateTargetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds a deployment under the same endpoint as a target for mirrored requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShadowExperimentService.ShadowExperimentServiceCreateTarget(
        new ShadowExperimentServiceCreateTargetRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            ExperimentId = "some example string",
            Body = new DeCreateShadowExperimentTargetRequest
            {
                Name = "some example string",
                TargetDeploymentId = "some example string",
            },
        });
    // TODO: Handle 'response' of type DeShadowExperimentTarget
}
catch (ApiException<ShadowExperimentServiceCreateTargetError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ShadowExperimentServiceCreateTargetRequest](Requests/ShadowExperimentService/ShadowExperimentServiceCreateTargetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeShadowExperimentTarget](Models/DeShadowExperimentTarget.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ShadowExperimentServiceCreateTargetError](Errors/ShadowExperimentServiceCreateTargetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; ShadowExperimentServiceDeleteShadowExperiment(ShadowExperimentServiceDeleteShadowExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a shadow experiment and its target records. The underlying deployments are not deleted.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShadowExperimentService.ShadowExperimentServiceDeleteShadowExperiment(
        new ShadowExperimentServiceDeleteShadowExperimentRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            Id = "some example string",
        });
    // TODO: Handle 'response' of type object
}
catch (ApiException<ShadowExperimentServiceDeleteShadowExperimentError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ShadowExperimentServiceDeleteShadowExperimentRequest](Requests/ShadowExperimentService/ShadowExperimentServiceDeleteShadowExperimentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ShadowExperimentServiceDeleteShadowExperimentError](Errors/ShadowExperimentServiceDeleteShadowExperimentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; ShadowExperimentServiceDeleteTarget(ShadowExperimentServiceDeleteTargetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a target from a shadow experiment without deleting the underlying deployment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShadowExperimentService.ShadowExperimentServiceDeleteTarget(
        new ShadowExperimentServiceDeleteTargetRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            ExperimentId = "some example string",
            Id = "some example string",
        });
    // TODO: Handle 'response' of type object
}
catch (ApiException<ShadowExperimentServiceDeleteTargetError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ShadowExperimentServiceDeleteTargetRequest](Requests/ShadowExperimentService/ShadowExperimentServiceDeleteTargetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ShadowExperimentServiceDeleteTargetError](Errors/ShadowExperimentServiceDeleteTargetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeShadowExperiment&gt; ShadowExperimentServiceGetShadowExperiment(ShadowExperimentServiceGetShadowExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a shadow experiment, including its sampling strategy and target deployments.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShadowExperimentService.ShadowExperimentServiceGetShadowExperiment(
        new ShadowExperimentServiceGetShadowExperimentRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            Id = "some example string",
        });
    // TODO: Handle 'response' of type DeShadowExperiment
}
catch (ApiException<ShadowExperimentServiceGetShadowExperimentError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ShadowExperimentServiceGetShadowExperimentRequest](Requests/ShadowExperimentService/ShadowExperimentServiceGetShadowExperimentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeShadowExperiment](Models/DeShadowExperiment.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ShadowExperimentServiceGetShadowExperimentError](Errors/ShadowExperimentServiceGetShadowExperimentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeShadowExperimentTarget&gt; ShadowExperimentServiceGetTarget(ShadowExperimentServiceGetTargetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves one target configured to receive mirrored requests from a shadow experiment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShadowExperimentService.ShadowExperimentServiceGetTarget(
        new ShadowExperimentServiceGetTargetRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            ExperimentId = "some example string",
            Id = "some example string",
        });
    // TODO: Handle 'response' of type DeShadowExperimentTarget
}
catch (ApiException<ShadowExperimentServiceGetTargetError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ShadowExperimentServiceGetTargetRequest](Requests/ShadowExperimentService/ShadowExperimentServiceGetTargetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeShadowExperimentTarget](Models/DeShadowExperimentTarget.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ShadowExperimentServiceGetTargetError](Errors/ShadowExperimentServiceGetTargetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListShadowExperimentsResponse&gt; ShadowExperimentServiceListShadowExperiments(ShadowExperimentServiceListShadowExperimentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists experiments that mirror sampled endpoint traffic to target deployments without affecting client responses. Set `includeTargets=true` to include target details inline.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShadowExperimentService.ShadowExperimentServiceListShadowExperiments(
        new ShadowExperimentServiceListShadowExperimentsRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
        });
    // TODO: Handle 'response' of type DeListShadowExperimentsResponse
}
catch (ApiException<ShadowExperimentServiceListShadowExperimentsError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ShadowExperimentServiceListShadowExperimentsRequest](Requests/ShadowExperimentService/ShadowExperimentServiceListShadowExperimentsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListShadowExperimentsResponse](Models/DeListShadowExperimentsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ShadowExperimentServiceListShadowExperimentsError](Errors/ShadowExperimentServiceListShadowExperimentsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListShadowExperimentTargetsResponse&gt; ShadowExperimentServiceListTargets(ShadowExperimentServiceListTargetsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the deployments that receive mirrored requests from a shadow experiment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShadowExperimentService.ShadowExperimentServiceListTargets(
        new ShadowExperimentServiceListTargetsRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            ExperimentId = "some example string",
        });
    // TODO: Handle 'response' of type DeListShadowExperimentTargetsResponse
}
catch (ApiException<ShadowExperimentServiceListTargetsError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ShadowExperimentServiceListTargetsRequest](Requests/ShadowExperimentService/ShadowExperimentServiceListTargetsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListShadowExperimentTargetsResponse](Models/DeListShadowExperimentTargetsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ShadowExperimentServiceListTargetsError](Errors/ShadowExperimentServiceListTargetsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeShadowExperiment&gt; ShadowExperimentServiceUpdateShadowExperiment(ShadowExperimentServiceUpdateShadowExperimentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a shadow experiment's description or source sampling strategy. `updateMask` is required; source changes also require the current `etag` in the request body.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShadowExperimentService.ShadowExperimentServiceUpdateShadowExperiment(
        new ShadowExperimentServiceUpdateShadowExperimentRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            Id = "some example string",
            UpdateMask = "some example string",
            Body = new DeUpdateShadowExperimentRequest(),
        });
    // TODO: Handle 'response' of type DeShadowExperiment
}
catch (ApiException<ShadowExperimentServiceUpdateShadowExperimentError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ShadowExperimentServiceUpdateShadowExperimentRequest](Requests/ShadowExperimentService/ShadowExperimentServiceUpdateShadowExperimentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeShadowExperiment](Models/DeShadowExperiment.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ShadowExperimentServiceUpdateShadowExperimentError](Errors/ShadowExperimentServiceUpdateShadowExperimentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeShadowExperimentTarget&gt; ShadowExperimentServiceUpdateTarget(ShadowExperimentServiceUpdateTargetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a shadow target's name, deployment, or description. `updateMask` is required and must select at least one mutable field.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShadowExperimentService.ShadowExperimentServiceUpdateTarget(
        new ShadowExperimentServiceUpdateTargetRequest
        {
            ProjectId = "some example string",
            EndpointId = "some example string",
            ExperimentId = "some example string",
            Id = "some example string",
            UpdateMask = "some example string",
            Body = new DeUpdateShadowExperimentTargetRequest(),
        });
    // TODO: Handle 'response' of type DeShadowExperimentTarget
}
catch (ApiException<ShadowExperimentServiceUpdateTargetError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ShadowExperimentServiceUpdateTargetRequest](Requests/ShadowExperimentService/ShadowExperimentServiceUpdateTargetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeShadowExperimentTarget](Models/DeShadowExperimentTarget.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ShadowExperimentServiceUpdateTargetError](Errors/ShadowExperimentServiceUpdateTargetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SharedVolumeService

> Source: [SharedVolumeService](Api/SharedVolumeService.cs)

<details>
<summary><code>Task&lt;GpuClustersSharedVolume&gt; SharedVolumeServiceCreate(SharedVolumeServiceCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Instant Clusters supports long-lived, resizable in-DC shared storage with user data persistence.
You can dynamically create and attach volumes to your cluster at cluster creation time, and resize as your data grows.
All shared storage is backed by multi-NIC bare metal paths, ensuring high-throughput and low-latency performance for shared storage.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SharedVolumeService.SharedVolumeServiceCreate(new SharedVolumeServiceCreateRequest
    {
        Body = new GpuClustersSharedVolumeCreateRequest
        {
            VolumeName = "some example string",
            SizeTib = 1,
            Region = "some example string",
        },
    });
    // TODO: Handle 'response' of type GpuClustersSharedVolume
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SharedVolumeServiceCreateRequest](Requests/SharedVolumeService/SharedVolumeServiceCreateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GpuClustersSharedVolume](Models/GpuClustersSharedVolume.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GpuClustersSharedVolumeDeleteResponse&gt; SharedVolumeServiceDelete(SharedVolumeServiceDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a shared volume. Note that if this volume is attached to a cluster, deleting will fail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SharedVolumeService.SharedVolumeServiceDelete(new SharedVolumeServiceDeleteRequest
    {
        VolumeId = "some example string",
    });
    // TODO: Handle 'response' of type GpuClustersSharedVolumeDeleteResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SharedVolumeServiceDeleteRequest](Requests/SharedVolumeService/SharedVolumeServiceDeleteRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GpuClustersSharedVolumeDeleteResponse](Models/GpuClustersSharedVolumeDeleteResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GpuClustersSharedVolume&gt; SharedVolumeServiceGet(SharedVolumeServiceGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve information about a specific shared volume.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SharedVolumeService.SharedVolumeServiceGet(new SharedVolumeServiceGetRequest
    {
        VolumeId = "some example string",
    });
    // TODO: Handle 'response' of type GpuClustersSharedVolume
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SharedVolumeServiceGetRequest](Requests/SharedVolumeService/SharedVolumeServiceGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GpuClustersSharedVolume](Models/GpuClustersSharedVolume.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GpuClustersSharedVolumes&gt; SharedVolumeServiceList(SharedVolumeServiceListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all shared volumes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SharedVolumeService.SharedVolumeServiceList(new SharedVolumeServiceListRequest());
    // TODO: Handle 'response' of type GpuClustersSharedVolumes
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SharedVolumeServiceListRequest](Requests/SharedVolumeService/SharedVolumeServiceListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GpuClustersSharedVolumes](Models/GpuClustersSharedVolumes.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GpuClustersSharedVolume&gt; SharedVolumeServiceUpdate(SharedVolumeServiceUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the configuration of an existing shared volume.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SharedVolumeService.SharedVolumeServiceUpdate(new SharedVolumeServiceUpdateRequest
    {
        Body = new GpuClustersSharedVolumeUpdateRequest { VolumeId = "some example string" },
    });
    // TODO: Handle 'response' of type GpuClustersSharedVolume
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SharedVolumeServiceUpdateRequest](Requests/SharedVolumeService/SharedVolumeServiceUpdateRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GpuClustersSharedVolume](Models/GpuClustersSharedVolume.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SupportedModelsService

> Source: [SupportedModelsService](Api/SupportedModelsService.cs)

<details>
<summary><code>Task&lt;DeSupportedModel&gt; SupportedModelsServiceGetSupportedModel(SupportedModelsServiceGetSupportedModelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a Together-hosted base model and the certified model, configuration, hardware, and performance profiles available for deployment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SupportedModelsService.SupportedModelsServiceGetSupportedModel(
        new SupportedModelsServiceGetSupportedModelRequest { Id = "some example string" });
    // TODO: Handle 'response' of type DeSupportedModel
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SupportedModelsServiceGetSupportedModelRequest](Requests/SupportedModelsService/SupportedModelsServiceGetSupportedModelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeSupportedModel](Models/DeSupportedModel.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListSupportedModelsResponse&gt; SupportedModelsServiceListSupportedModels(SupportedModelsServiceListSupportedModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists Together-hosted base models that can be deployed for dedicated inference, together with their capabilities and certified deployment profiles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SupportedModelsService.SupportedModelsServiceListSupportedModels(
        new SupportedModelsServiceListSupportedModelsRequest());
    // TODO: Handle 'response' of type DeListSupportedModelsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SupportedModelsServiceListSupportedModelsRequest](Requests/SupportedModelsService/SupportedModelsServiceListSupportedModelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListSupportedModelsResponse](Models/DeListSupportedModelsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideoApi

> Source: [VideoApi](Api/VideoApi.cs)

<details>
<summary><code>Task&lt;VideoJob&gt; CreateVideo(CreateVideoOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a video

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideoApi.CreateVideo(new CreateVideoOperationRequest());
    // TODO: Handle 'response' of type VideoJob
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateVideoOperationRequest](Requests/VideoApi/CreateVideoOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoJob](Models/VideoJob.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoJob&gt; RetrieveVideo(RetrieveVideoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch video metadata

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideoApi.RetrieveVideo(new RetrieveVideoRequest { Id = "some example string" });
    // TODO: Handle 'response' of type VideoJob
}
catch (ApiException<RetrieveVideoError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RetrieveVideoRequest](Requests/VideoApi/RetrieveVideoRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoJob](Models/VideoJob.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RetrieveVideoError](Errors/RetrieveVideoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Voices

> Source: [Voices](Api/Voices.cs)

<details>
<summary><code>Task&lt;ListVoicesResponse&gt; FetchVoices(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch available voices for each model

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Voices.FetchVoices();
    // TODO: Handle 'response' of type ListVoicesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ListVoicesResponse](Models/ListVoicesResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VolumeService

> Source: [VolumeService](Api/VolumeService.cs)

<details>
<summary><code>Task&lt;DeModel&gt; VolumeServiceCreateModel(VolumeServiceCreateModelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Registers a custom model resource in the project. Registration creates the model's metadata; upload or import model files separately before deploying it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VolumeService.VolumeServiceCreateModel(new VolumeServiceCreateModelRequest
    {
        ProjectId = "some example string",
        Body = new DeCreateModelRequest
        {
            Name = "some example string",
            Type = "some example string",
            BaseModelId = "some example string",
        },
    });
    // TODO: Handle 'response' of type DeModel
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VolumeServiceCreateModelRequest](Requests/VolumeService/VolumeServiceCreateModelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeModel](Models/DeModel.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeRemoteUpload&gt; VolumeServiceCreateRemoteModelUpload(VolumeServiceCreateRemoteModelUploadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Starts an asynchronous job that imports model files from Hugging Face or a presigned URL into a registered model and creates a model revision when the import completes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VolumeService.VolumeServiceCreateRemoteModelUpload(
        new VolumeServiceCreateRemoteModelUploadRequest
        {
            ProjectId = "some example string",
            Body = new DeCreateRemoteUploadSpec { ModelId = "some example string", RemoteUrl = "some example string" },
        });
    // TODO: Handle 'response' of type DeRemoteUpload
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VolumeServiceCreateRemoteModelUploadRequest](Requests/VolumeService/VolumeServiceCreateRemoteModelUploadRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeRemoteUpload](Models/DeRemoteUpload.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; VolumeServiceDeleteModel(VolumeServiceDeleteModelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Permanently deletes a custom model resource. The model must not be in use by an active deployment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VolumeService.VolumeServiceDeleteModel(new VolumeServiceDeleteModelRequest
    {
        ProjectId = "some example string",
        Id = "some example string",
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VolumeServiceDeleteModelRequest](Requests/VolumeService/VolumeServiceDeleteModelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeModel&gt; VolumeServiceGetModel(VolumeServiceGetModelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a custom model's metadata, visibility, weight information, and base-model relationship.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VolumeService.VolumeServiceGetModel(new VolumeServiceGetModelRequest
    {
        ProjectId = "some example string",
        Id = "some example string",
    });
    // TODO: Handle 'response' of type DeModel
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VolumeServiceGetModelRequest](Requests/VolumeService/VolumeServiceGetModelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeModel](Models/DeModel.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeRemoteUpload&gt; VolumeServiceGetRemoteModelUpload(VolumeServiceGetRemoteModelUploadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the status, progress details, retry counts, and timestamps for a remote model import job.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VolumeService.VolumeServiceGetRemoteModelUpload(
        new VolumeServiceGetRemoteModelUploadRequest { ProjectId = "some example string", Id = "some example string" });
    // TODO: Handle 'response' of type DeRemoteUpload
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VolumeServiceGetRemoteModelUploadRequest](Requests/VolumeService/VolumeServiceGetRemoteModelUploadRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeRemoteUpload](Models/DeRemoteUpload.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListRevisionsResponseRevision&gt; VolumeServiceGetRevisionByModelType(VolumeServiceGetRevisionByModelTypeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves metadata for one immutable revision of a custom model's files.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VolumeService.VolumeServiceGetRevisionByModelType(
        new VolumeServiceGetRevisionByModelTypeRequest
        {
            ProjectId = "some example string",
            Id = "some example string",
            RevisionId = "some example string",
        });
    // TODO: Handle 'response' of type DeListRevisionsResponseRevision
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VolumeServiceGetRevisionByModelTypeRequest](Requests/VolumeService/VolumeServiceGetRevisionByModelTypeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListRevisionsResponseRevision](Models/DeListRevisionsResponseRevision.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListFilesResponse&gt; VolumeServiceListModelFiles(VolumeServiceListModelFilesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists files in the latest or specified revision of a model, including paths, sizes, and content hashes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VolumeService.VolumeServiceListModelFiles(new VolumeServiceListModelFilesRequest
    {
        ProjectId = "some example string",
        Id = "some example string",
    });
    // TODO: Handle 'response' of type DeListFilesResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VolumeServiceListModelFilesRequest](Requests/VolumeService/VolumeServiceListModelFilesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListFilesResponse](Models/DeListFilesResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListRevisionsResponse&gt; VolumeServiceListModelRevisions(VolumeServiceListModelRevisionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists the immutable file revisions available for a custom model, newest first.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VolumeService.VolumeServiceListModelRevisions(new VolumeServiceListModelRevisionsRequest
    {
        ProjectId = "some example string",
        Id = "some example string",
    });
    // TODO: Handle 'response' of type DeListRevisionsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VolumeServiceListModelRevisionsRequest](Requests/VolumeService/VolumeServiceListModelRevisionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListRevisionsResponse](Models/DeListRevisionsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListModelsResponse&gt; VolumeServiceListModels(VolumeServiceListModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists custom model resources owned by the specified project. Use the organization endpoint to list models shared across projects or the supported-model catalog to discover Together-hosted base models.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VolumeService.VolumeServiceListModels(new VolumeServiceListModelsRequest
    {
        ProjectId = "some example string",
    });
    // TODO: Handle 'response' of type DeListModelsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VolumeServiceListModelsRequest](Requests/VolumeService/VolumeServiceListModelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListModelsResponse](Models/DeListModelsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListModelsResponse&gt; VolumeServiceListOrganizationModels(VolumeServiceListOrganizationModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists custom models shared with every project in the specified organization. Project-private and public models are not included.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VolumeService.VolumeServiceListOrganizationModels(
        new VolumeServiceListOrganizationModelsRequest { OrganizationId = "some example string" });
    // TODO: Handle 'response' of type DeListModelsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VolumeServiceListOrganizationModelsRequest](Requests/VolumeService/VolumeServiceListOrganizationModelsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListModelsResponse](Models/DeListModelsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListRemoteUploadEventsResponse&gt; VolumeServiceListRemoteModelUploadEvents(VolumeServiceListRemoteModelUploadEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists progress and diagnostic events for a remote model import job.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VolumeService.VolumeServiceListRemoteModelUploadEvents(
        new VolumeServiceListRemoteModelUploadEventsRequest
        {
            ProjectId = "some example string",
            Id = "some example string",
        });
    // TODO: Handle 'response' of type DeListRemoteUploadEventsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VolumeServiceListRemoteModelUploadEventsRequest](Requests/VolumeService/VolumeServiceListRemoteModelUploadEventsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListRemoteUploadEventsResponse](Models/DeListRemoteUploadEventsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeListRemoteUploadsResponse&gt; VolumeServiceListRemoteModelUploads(VolumeServiceListRemoteModelUploadsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists asynchronous jobs that import model files from Hugging Face or a presigned remote URL.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VolumeService.VolumeServiceListRemoteModelUploads(
        new VolumeServiceListRemoteModelUploadsRequest { ProjectId = "some example string" });
    // TODO: Handle 'response' of type DeListRemoteUploadsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VolumeServiceListRemoteModelUploadsRequest](Requests/VolumeService/VolumeServiceListRemoteModelUploadsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeListRemoteUploadsResponse](Models/DeListRemoteUploadsResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeModel&gt; VolumeServiceUpdateModel(VolumeServiceUpdateModelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates mutable model metadata such as its inference name, description, base model, or visibility.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VolumeService.VolumeServiceUpdateModel(new VolumeServiceUpdateModelRequest
    {
        ProjectId = "some example string",
        Id = "some example string",
        Body = new DeUpdateModelRequest(),
    });
    // TODO: Handle 'response' of type DeModel
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VolumeServiceUpdateModelRequest](Requests/VolumeService/VolumeServiceUpdateModelRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeModel](Models/DeModel.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Volumes

> Source: [Volumes](Api/Volumes.cs)

<details>
<summary><code>Task&lt;object&gt; DeleteAVolume(DeleteAVolumeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete an existing volume

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Volumes.DeleteAVolume(new DeleteAVolumeRequest { Id = "some example string" });
    // TODO: Handle 'response' of type object
}
catch (ApiException<DeleteAVolumeError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteAVolumeRequest](Requests/Volumes/DeleteAVolumeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeleteAVolumeError](Errors/DeleteAVolumeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VolumeResponseItem&gt; GetAVolumeByIdOrName(GetAVolumeByIdOrNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve details of a specific volume by its ID or name

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Volumes.GetAVolumeByIdOrName(new GetAVolumeByIdOrNameRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type VolumeResponseItem
}
catch (ApiException<GetAVolumeByIdOrNameError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAVolumeByIdOrNameRequest](Requests/Volumes/GetAVolumeByIdOrNameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VolumeResponseItem](Models/VolumeResponseItem.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAVolumeByIdOrNameError](Errors/GetAVolumeByIdOrNameError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VolumeResponseItem&gt; UpdateAVolume(UpdateAVolumeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an existing volume's configuration or contents

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Volumes.UpdateAVolume(new UpdateAVolumeRequest
    {
        Id = "some example string",
        Body = new UpdateVolumeRequest(),
    });
    // TODO: Handle 'response' of type VolumeResponseItem
}
catch (ApiException<UpdateAVolumeError> ex)
{
    if (ex.Error.TryGetAnonymousObject(out var error))
    {
        // TODO: Handle 'error' of type object
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateAVolumeRequest](Requests/Volumes/UpdateAVolumeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VolumeResponseItem](Models/VolumeResponseItem.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UpdateAVolumeError](Errors/UpdateAVolumeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Evaluation

> Source: [Evaluation](Api/Evaluation.cs)

<details>
<summary><code>Task&lt;EvaluationResponse&gt; CreateEvaluationJob(CreateEvaluationJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Evaluation.CreateEvaluationJob(new CreateEvaluationJobRequest
    {
        Body = new EvaluationTypedRequest
        {
            Type = Type14.Classify,
            Parameters = new EvaluationClassifyParameters
            {
                Judge = new EvaluationJudgeModelConfig
                {
                    Model = "some example string",
                    SystemTemplate = "some example string",
                    ModelSource = ModelSource.Serverless,
                },
                Labels = ["some example string"],
                PassLabels = ["some example string"],
                InputDataFilePath = "some example string",
            },
        },
    });
    // TODO: Handle 'response' of type EvaluationResponse
}
catch (ApiException<CreateEvaluationJobError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateEvaluationJobRequest](Requests/Evaluation/CreateEvaluationJobRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EvaluationResponse](Models/EvaluationResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreateEvaluationJobError](Errors/CreateEvaluationJobError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;EvaluationJob&gt;&gt; GetAllEvaluationJobs(GetAllEvaluationJobsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Evaluation.GetAllEvaluationJobs(new GetAllEvaluationJobsRequest());
    // TODO: Handle 'response' of type IReadOnlyList<EvaluationJob>
}
catch (ApiException<GetAllEvaluationJobsError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAllEvaluationJobsRequest](Requests/Evaluation/GetAllEvaluationJobsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[EvaluationJob](Models/EvaluationJob.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAllEvaluationJobsError](Errors/GetAllEvaluationJobsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EvaluationJob&gt; GetEvaluationJobDetails(GetEvaluationJobDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Evaluation.GetEvaluationJobDetails(new GetEvaluationJobDetailsRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type EvaluationJob
}
catch (ApiException<GetEvaluationJobDetailsError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEvaluationJobDetailsRequest](Requests/Evaluation/GetEvaluationJobDetailsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EvaluationJob](Models/EvaluationJob.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEvaluationJobDetailsError](Errors/GetEvaluationJobDetailsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EvaluationStatusResponse&gt; GetEvaluationJobStatusAndResults(GetEvaluationJobStatusAndResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Evaluation.GetEvaluationJobStatusAndResults(new GetEvaluationJobStatusAndResultsRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type EvaluationStatusResponse
}
catch (ApiException<GetEvaluationJobStatusAndResultsError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetEvaluationJobStatusAndResultsRequest](Requests/Evaluation/GetEvaluationJobStatusAndResultsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EvaluationStatusResponse](Models/EvaluationStatusResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetEvaluationJobStatusAndResultsError](Errors/GetEvaluationJobStatusAndResultsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EvaluationModelListResponse&gt; GetModelList(GetModelListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Evaluation.GetModelList(new GetModelListRequest());
    // TODO: Handle 'response' of type EvaluationModelListResponse
}
catch (ApiException<GetModelListError> ex)
{
    if (ex.Error.TryGetErrorData(out var error))
    {
        // TODO: Handle 'error' of type ErrorData
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetModelListRequest](Requests/Evaluation/GetModelListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EvaluationModelListResponse](Models/EvaluationModelListResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetModelListError](Errors/GetModelListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

