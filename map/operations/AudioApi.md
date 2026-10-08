<!-- Generated file — do not edit; regenerated with the SDK. -->

# AudioApi — operations

Accessor: `client.AudioApi` · Source: `Api/AudioApi.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AudioSpeech

- **Auth**: `options.BearerAuth`
- **Signature**: `AudioSpeech(AudioSpeechOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `BinaryContent`
- **Error**: `ApiException<AudioSpeechError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AudioSpeechOperationRequest` | `Requests/AudioApi/AudioSpeechOperationRequest.cs` |
| `AudioSpeechRequest` | `Models/AudioSpeechRequest.cs` |
| `AudioSpeechError` | `Errors/AudioSpeechError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### AudioTranscriptions

- **Auth**: `options.BearerAuth`
- **Signature**: `AudioTranscriptions(AudioTranscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `File`
- **Returns**: `AudioTranscriptionResponse`
- **Error**: `ApiException<AudioTranscriptionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400, 401, 429] · `TryGetNoContent(out RawError)` [413] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AudioTranscriptionsRequest` | `Requests/AudioApi/AudioTranscriptionsRequest.cs` |
| `File1` | `Models/AnyOf/File1.cs` |
| `Model3` | `Models/Enums/Model3.cs` |
| `ResponseFormat1` | `Models/Enums/ResponseFormat1.cs` |
| `TimestampGranularities1` | `Models/AnyOf/TimestampGranularities1.cs` |
| `AudioTranscriptionResponse` | `Models/AnyOf/AudioTranscriptionResponse.cs` |
| `AudioTranscriptionsError` | `Errors/AudioTranscriptionsError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### AudioTranslations

- **Auth**: `options.BearerAuth`
- **Signature**: `AudioTranslations(AudioTranslationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `File`
- **Returns**: `AudioTranslationResponse`
- **Error**: `ApiException<AudioTranslationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400, 401, 429] · `TryGetNoContent(out RawError)` [413] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AudioTranslationsRequest` | `Requests/AudioApi/AudioTranslationsRequest.cs` |
| `File1` | `Models/AnyOf/File1.cs` |
| `Model4` | `Models/Enums/Model4.cs` |
| `ResponseFormat1` | `Models/Enums/ResponseFormat1.cs` |
| `TimestampGranularities1` | `Models/AnyOf/TimestampGranularities1.cs` |
| `AudioTranslationResponse` | `Models/AnyOf/AudioTranslationResponse.cs` |
| `AudioTranslationsError` | `Errors/AudioTranslationsError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### RealtimeTranscription

- **Auth**: `options.BearerAuth`
- **Signature**: `RealtimeTranscription(RealtimeTranscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Model`
- **Query params (wire ← C#)**: `model` ← `Model`, `input_audio_format` ← `InputAudioFormat`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RealtimeTranscriptionRequest` | `Requests/AudioApi/RealtimeTranscriptionRequest.cs` |
| `InputAudioFormat` | `Models/Enums/InputAudioFormat.cs` |

### RealtimeTts

- **Auth**: `options.BearerAuth`
- **Signature**: `RealtimeTts(RealtimeTtsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `model` ← `Model`, `voice` ← `Voice`, `max_partial_length` ← `MaxPartialLength`, `language` ← `Language`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RealtimeTtsRequest` | `Requests/AudioApi/RealtimeTtsRequest.cs` |
| `Model7Enum` | `Models/Enums/Model7Enum.cs` |

