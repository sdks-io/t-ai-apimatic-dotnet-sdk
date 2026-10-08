<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeploymentsVolumes — operations

Accessor: `client.DeploymentsVolumes` · Source: `Api/DeploymentsVolumes.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateANewVolume

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateANewVolume(CreateANewVolumeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `VolumeResponseItem`
- **Error**: `ApiException<CreateANewVolumeError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [400, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateANewVolumeRequest` | `Requests/DeploymentsVolumes/CreateANewVolumeRequest.cs` |
| `CreateVolumeRequest` | `Models/CreateVolumeRequest.cs` |
| `VolumeResponseItem` | `Models/VolumeResponseItem.cs` |
| `CreateANewVolumeError` | `Errors/CreateANewVolumeError.cs` |

### GetTheListOfProjectVolumes

- **Auth**: `options.BearerAuth`
- **Signature**: `GetTheListOfProjectVolumes(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ListVolumesResponse`
- **Error**: `ApiException<GetTheListOfProjectVolumesError>` — **Case A (typed)**
- **Error accessors**: `TryGetAnonymousObject(out object)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListVolumesResponse` | `Models/ListVolumesResponse.cs` |
| `GetTheListOfProjectVolumesError` | `Errors/GetTheListOfProjectVolumesError.cs` |

