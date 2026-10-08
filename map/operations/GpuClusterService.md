<!-- Generated file — do not edit; regenerated with the SDK. -->

# GpuClusterService — operations

Accessor: `client.GpuClusterService` · Source: `Api/GpuClusterService.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GPuClusterServiceCreate

- **Auth**: `options.BearerAuth`
- **Signature**: `GPuClusterServiceCreate(GPuClusterServiceCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GpuClusterInfo`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GPuClusterServiceCreateRequest` | `Requests/GpuClusterService/GPuClusterServiceCreateRequest.cs` |
| `GpuClusterCreateRequest2` | `Models/AnyOf/GpuClusterCreateRequest2.cs` |
| `GpuClusterInfo` | `Models/GpuClusterInfo.cs` |

### GPuClusterServiceDelete

- **Auth**: `options.BearerAuth`
- **Signature**: `GPuClusterServiceDelete(GPuClusterServiceDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClusterId`
- **Returns**: `GpuClusterDeleteResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GPuClusterServiceDeleteRequest` | `Requests/GpuClusterService/GPuClusterServiceDeleteRequest.cs` |
| `GpuClusterDeleteResponse` | `Models/GpuClusterDeleteResponse.cs` |

### GPuClusterServiceGet

- **Auth**: `options.BearerAuth`
- **Signature**: `GPuClusterServiceGet(GPuClusterServiceGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClusterId`
- **Returns**: `GpuClusterInfo`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GPuClusterServiceGetRequest` | `Requests/GpuClusterService/GPuClusterServiceGetRequest.cs` |
| `GpuClusterInfo` | `Models/GpuClusterInfo.cs` |

### GPuClusterServiceList

- **Auth**: `options.BearerAuth`
- **Signature**: `GPuClusterServiceList(GPuClusterServiceListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `projectId` ← `ProjectId`
- **Returns**: `GpuClusters`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GPuClusterServiceListRequest` | `Requests/GpuClusterService/GPuClusterServiceListRequest.cs` |
| `GpuClusters` | `Models/GpuClusters.cs` |

### GPuClusterServiceUpdate

- **Auth**: `options.BearerAuth`
- **Signature**: `GPuClusterServiceUpdate(GPuClusterServiceUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ClusterId`, `Body`
- **Returns**: `GpuClusterInfo`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GPuClusterServiceUpdateRequest` | `Requests/GpuClusterService/GPuClusterServiceUpdateRequest.cs` |
| `GpuClusterUpdateRequest` | `Models/GpuClusterUpdateRequest.cs` |
| `GpuClusterInfo` | `Models/GpuClusterInfo.cs` |

