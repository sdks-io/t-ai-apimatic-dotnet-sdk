<!-- Generated file — do not edit; regenerated with the SDK. -->

# Rerank — operations

Accessor: `client.Rerank` · Source: `Api/Rerank.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### RerankInvoke

- **Auth**: `options.BearerAuth`
- **Signature**: `RerankInvoke(RerankOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `RerankResponse`
- **Error**: `ApiException<RerankError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400, 401, 404, 429, 503, 504] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RerankOperationRequest` | `Requests/Rerank/RerankOperationRequest.cs` |
| `RerankRequest` | `Models/RerankRequest.cs` |
| `RerankResponse` | `Models/RerankResponse.cs` |
| `RerankError` | `Errors/RerankError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

