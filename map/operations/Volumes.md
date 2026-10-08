<!-- Generated file — do not edit; regenerated with the SDK. -->

# Volumes — operations

Accessor: `client.Volumes` · Source: `Api/Volumes.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteAVolume

- **Auth**: `options.BearerAuth`
- **Signature**: `DeleteAVolume(DeleteAVolumeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `object`
- **Error**: `ApiException<DeleteAVolumeError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteAVolumeRequest` | `Requests/Volumes/DeleteAVolumeRequest.cs` |
| `DeleteAVolumeError` | `Errors/DeleteAVolumeError.cs` |

### GetAVolumeByIdOrName

- **Auth**: `options.BearerAuth`
- **Signature**: `GetAVolumeByIdOrName(GetAVolumeByIdOrNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `version` ← `Version`
- **Returns**: `VolumeResponseItem`
- **Error**: `ApiException<GetAVolumeByIdOrNameError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [400, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAVolumeByIdOrNameRequest` | `Requests/Volumes/GetAVolumeByIdOrNameRequest.cs` |
| `VolumeResponseItem` | `Models/VolumeResponseItem.cs` |
| `GetAVolumeByIdOrNameError` | `Errors/GetAVolumeByIdOrNameError.cs` |

### UpdateAVolume

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateAVolume(UpdateAVolumeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `VolumeResponseItem`
- **Error**: `ApiException<UpdateAVolumeError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [400, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateAVolumeRequest` | `Requests/Volumes/UpdateAVolumeRequest.cs` |
| `UpdateVolumeRequest` | `Models/UpdateVolumeRequest.cs` |
| `VolumeResponseItem` | `Models/VolumeResponseItem.cs` |
| `UpdateAVolumeError` | `Errors/UpdateAVolumeError.cs` |

