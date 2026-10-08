<!-- Generated file — do not edit; regenerated with the SDK. -->

# Embeddings — operations

Accessor: `client.Embeddings` · Source: `Api/Embeddings.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### EmbeddingsInvoke

- **Auth**: `options.BearerAuth`
- **Signature**: `EmbeddingsInvoke(EmbeddingsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `EmbeddingsResponse`
- **Error**: `ApiException<EmbeddingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400, 401, 404, 429, 503, 504] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EmbeddingsOperationRequest` | `Requests/Embeddings/EmbeddingsOperationRequest.cs` |
| `EmbeddingsRequest` | `Models/EmbeddingsRequest.cs` |
| `EmbeddingsResponse` | `Models/EmbeddingsResponse.cs` |
| `EmbeddingsError` | `Errors/EmbeddingsError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

