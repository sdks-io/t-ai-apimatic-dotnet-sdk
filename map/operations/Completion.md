<!-- Generated file — do not edit; regenerated with the SDK. -->

# Completion — operations

Accessor: `client.Completion` · Source: `Api/Completion.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Completions

- **Auth**: `options.BearerAuth`
- **Signature**: `Completions(CompletionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CompletionResponse`
- **Error**: `ApiException<CompletionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400, 401, 404, 429, 503, 504] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CompletionsRequest` | `Requests/Completion/CompletionsRequest.cs` |
| `CompletionRequest` | `Models/CompletionRequest.cs` |
| `CompletionResponse` | `Models/CompletionResponse.cs` |
| `CompletionsError` | `Errors/CompletionsError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

