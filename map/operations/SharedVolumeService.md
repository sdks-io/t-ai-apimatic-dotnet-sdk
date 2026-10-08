<!-- Generated file — do not edit; regenerated with the SDK. -->

# SharedVolumeService — operations

Accessor: `client.SharedVolumeService` · Source: `Api/SharedVolumeService.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SharedVolumeServiceCreate

- **Auth**: `options.BearerAuth`
- **Signature**: `SharedVolumeServiceCreate(SharedVolumeServiceCreateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GpuClustersSharedVolume`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SharedVolumeServiceCreateRequest` | `Requests/SharedVolumeService/SharedVolumeServiceCreateRequest.cs` |
| `GpuClustersSharedVolumeCreateRequest` | `Models/GpuClustersSharedVolumeCreateRequest.cs` |
| `GpuClustersSharedVolume` | `Models/GpuClustersSharedVolume.cs` |

### SharedVolumeServiceDelete

- **Auth**: `options.BearerAuth`
- **Signature**: `SharedVolumeServiceDelete(SharedVolumeServiceDeleteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VolumeId`
- **Returns**: `GpuClustersSharedVolumeDeleteResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SharedVolumeServiceDeleteRequest` | `Requests/SharedVolumeService/SharedVolumeServiceDeleteRequest.cs` |
| `GpuClustersSharedVolumeDeleteResponse` | `Models/GpuClustersSharedVolumeDeleteResponse.cs` |

### SharedVolumeServiceGet

- **Auth**: `options.BearerAuth`
- **Signature**: `SharedVolumeServiceGet(SharedVolumeServiceGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `VolumeId`
- **Returns**: `GpuClustersSharedVolume`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SharedVolumeServiceGetRequest` | `Requests/SharedVolumeService/SharedVolumeServiceGetRequest.cs` |
| `GpuClustersSharedVolume` | `Models/GpuClustersSharedVolume.cs` |

### SharedVolumeServiceList

- **Auth**: `options.BearerAuth`
- **Signature**: `SharedVolumeServiceList(SharedVolumeServiceListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `projectId` ← `ProjectId`
- **Returns**: `GpuClustersSharedVolumes`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SharedVolumeServiceListRequest` | `Requests/SharedVolumeService/SharedVolumeServiceListRequest.cs` |
| `GpuClustersSharedVolumes` | `Models/GpuClustersSharedVolumes.cs` |

### SharedVolumeServiceUpdate

- **Auth**: `options.BearerAuth`
- **Signature**: `SharedVolumeServiceUpdate(SharedVolumeServiceUpdateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `GpuClustersSharedVolume`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SharedVolumeServiceUpdateRequest` | `Requests/SharedVolumeService/SharedVolumeServiceUpdateRequest.cs` |
| `GpuClustersSharedVolumeUpdateRequest` | `Models/GpuClustersSharedVolumeUpdateRequest.cs` |
| `GpuClustersSharedVolume` | `Models/GpuClustersSharedVolume.cs` |

