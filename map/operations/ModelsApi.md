<!-- Generated file — do not edit; regenerated with the SDK. -->

# ModelsApi — operations

Accessor: `client.ModelsApi` · Source: `Api/ModelsApi.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### Models

- **Auth**: `options.BearerAuth`
- **Signature**: `Models(ModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `dedicated` ← `Dedicated`
- **Returns**: `IReadOnlyList<ModelInfo>`
- **Error**: `ApiException<ModelsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400, 401, 404, 429, 504] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ModelsRequest` | `Requests/ModelsApi/ModelsRequest.cs` |
| `ModelInfo` | `Models/ModelInfo.cs` |
| `ModelsError` | `Errors/ModelsError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### UploadModel

- **Auth**: `options.BearerAuth`
- **Signature**: `UploadModel(UploadModelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ModelUploadSuccessResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UploadModelRequest` | `Requests/ModelsApi/UploadModelRequest.cs` |
| `ModelUploadRequest` | `Models/ModelUploadRequest.cs` |
| `ModelUploadSuccessResponse` | `Models/ModelUploadSuccessResponse.cs` |

