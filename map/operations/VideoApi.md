<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideoApi — operations

Accessor: `client.VideoApi` · Source: `Api/VideoApi.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateVideo

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateVideo(CreateVideoOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `VideoJob`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateVideoOperationRequest` | `Requests/VideoApi/CreateVideoOperationRequest.cs` |
| `CreateVideoRequest` | `Models/CreateVideoRequest.cs` |
| `VideoJob` | `Models/VideoJob.cs` |

### RetrieveVideo

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveVideo(RetrieveVideoRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `VideoJob`
- **Error**: `ApiException<RetrieveVideoError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RetrieveVideoRequest` | `Requests/VideoApi/RetrieveVideoRequest.cs` |
| `VideoJob` | `Models/VideoJob.cs` |
| `RetrieveVideoError` | `Errors/RetrieveVideoError.cs` |

