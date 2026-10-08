<!-- Generated file — do not edit; regenerated with the SDK. -->

# Chat — operations

Accessor: `client.Chat` · Source: `Api/Chat.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ChatCompletions

- **Auth**: `options.BearerAuth`
- **Signature**: `ChatCompletions(ChatCompletionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ChatCompletionResponse`
- **Error**: `ApiException<ChatCompletionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400, 401, 404, 429, 503, 504] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChatCompletionsRequest` | `Requests/Chat/ChatCompletionsRequest.cs` |
| `ChatCompletionRequest` | `Models/ChatCompletionRequest.cs` |
| `ChatCompletionResponse` | `Models/ChatCompletionResponse.cs` |
| `ChatCompletionsError` | `Errors/ChatCompletionsError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

