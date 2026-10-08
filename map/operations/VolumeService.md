<!-- Generated file — do not edit; regenerated with the SDK. -->

# VolumeService — operations

Accessor: `client.VolumeService` · Source: `Api/VolumeService.cs` · 13 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### VolumeServiceCreateModel

- **Auth**: `options.BearerAuth`
- **Signature**: `VolumeServiceCreateModel(VolumeServiceCreateModelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Body`
- **Returns**: `DeModel`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VolumeServiceCreateModelRequest` | `Requests/VolumeService/VolumeServiceCreateModelRequest.cs` |
| `DeCreateModelRequest` | `Models/DeCreateModelRequest.cs` |
| `DeModel` | `Models/DeModel.cs` |

### VolumeServiceCreateRemoteModelUpload

- **Auth**: `options.BearerAuth`
- **Signature**: `VolumeServiceCreateRemoteModelUpload(VolumeServiceCreateRemoteModelUploadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Body`
- **Returns**: `DeRemoteUpload`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VolumeServiceCreateRemoteModelUploadRequest` | `Requests/VolumeService/VolumeServiceCreateRemoteModelUploadRequest.cs` |
| `DeCreateRemoteUploadSpec` | `Models/DeCreateRemoteUploadSpec.cs` |
| `DeRemoteUpload` | `Models/DeRemoteUpload.cs` |

### VolumeServiceDeleteModel

- **Auth**: `options.BearerAuth`
- **Signature**: `VolumeServiceDeleteModel(VolumeServiceDeleteModelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Id`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VolumeServiceDeleteModelRequest` | `Requests/VolumeService/VolumeServiceDeleteModelRequest.cs` |

### VolumeServiceGetModel

- **Auth**: `options.BearerAuth`
- **Signature**: `VolumeServiceGetModel(VolumeServiceGetModelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Id`
- **Returns**: `DeModel`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VolumeServiceGetModelRequest` | `Requests/VolumeService/VolumeServiceGetModelRequest.cs` |
| `DeModel` | `Models/DeModel.cs` |

### VolumeServiceGetRemoteModelUpload

- **Auth**: `options.BearerAuth`
- **Signature**: `VolumeServiceGetRemoteModelUpload(VolumeServiceGetRemoteModelUploadRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Id`
- **Returns**: `DeRemoteUpload`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VolumeServiceGetRemoteModelUploadRequest` | `Requests/VolumeService/VolumeServiceGetRemoteModelUploadRequest.cs` |
| `DeRemoteUpload` | `Models/DeRemoteUpload.cs` |

### VolumeServiceGetRevisionByModelType

- **Auth**: `options.BearerAuth`
- **Signature**: `VolumeServiceGetRevisionByModelType(VolumeServiceGetRevisionByModelTypeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Id`, `RevisionId`
- **Returns**: `DeListRevisionsResponseRevision`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VolumeServiceGetRevisionByModelTypeRequest` | `Requests/VolumeService/VolumeServiceGetRevisionByModelTypeRequest.cs` |
| `DeListRevisionsResponseRevision` | `Models/DeListRevisionsResponseRevision.cs` |

### VolumeServiceListModelFiles

- **Auth**: `options.BearerAuth`
- **Signature**: `VolumeServiceListModelFiles(VolumeServiceListModelFilesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Id`
- **Query params (wire ← C#)**: `revisionId` ← `RevisionId`
- **Returns**: `DeListFilesResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VolumeServiceListModelFilesRequest` | `Requests/VolumeService/VolumeServiceListModelFilesRequest.cs` |
| `DeListFilesResponse` | `Models/DeListFilesResponse.cs` |

### VolumeServiceListModelRevisions

- **Auth**: `options.BearerAuth`
- **Signature**: `VolumeServiceListModelRevisions(VolumeServiceListModelRevisionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Id`
- **Returns**: `DeListRevisionsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VolumeServiceListModelRevisionsRequest` | `Requests/VolumeService/VolumeServiceListModelRevisionsRequest.cs` |
| `DeListRevisionsResponse` | `Models/DeListRevisionsResponse.cs` |

### VolumeServiceListModels

- **Auth**: `options.BearerAuth`
- **Signature**: `VolumeServiceListModels(VolumeServiceListModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `visibility` ← `Visibility`, `organizationId` ← `OrganizationId`, `limit` ← `Limit`, `after` ← `After`
- **Returns**: `DeListModelsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VolumeServiceListModelsRequest` | `Requests/VolumeService/VolumeServiceListModelsRequest.cs` |
| `Visibility5` | `Models/Enums/Visibility5.cs` |
| `DeListModelsResponse` | `Models/DeListModelsResponse.cs` |

### VolumeServiceListOrganizationModels

- **Auth**: `options.BearerAuth`
- **Signature**: `VolumeServiceListOrganizationModels(VolumeServiceListOrganizationModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrganizationId`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `after` ← `After`
- **Returns**: `DeListModelsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VolumeServiceListOrganizationModelsRequest` | `Requests/VolumeService/VolumeServiceListOrganizationModelsRequest.cs` |
| `DeListModelsResponse` | `Models/DeListModelsResponse.cs` |

### VolumeServiceListRemoteModelUploadEvents

- **Auth**: `options.BearerAuth`
- **Signature**: `VolumeServiceListRemoteModelUploadEvents(VolumeServiceListRemoteModelUploadEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Id`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `after` ← `After`
- **Returns**: `DeListRemoteUploadEventsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VolumeServiceListRemoteModelUploadEventsRequest` | `Requests/VolumeService/VolumeServiceListRemoteModelUploadEventsRequest.cs` |
| `DeListRemoteUploadEventsResponse` | `Models/DeListRemoteUploadEventsResponse.cs` |

### VolumeServiceListRemoteModelUploads

- **Auth**: `options.BearerAuth`
- **Signature**: `VolumeServiceListRemoteModelUploads(VolumeServiceListRemoteModelUploadsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `after` ← `After`
- **Returns**: `DeListRemoteUploadsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VolumeServiceListRemoteModelUploadsRequest` | `Requests/VolumeService/VolumeServiceListRemoteModelUploadsRequest.cs` |
| `DeListRemoteUploadsResponse` | `Models/DeListRemoteUploadsResponse.cs` |

### VolumeServiceUpdateModel

- **Auth**: `options.BearerAuth`
- **Signature**: `VolumeServiceUpdateModel(VolumeServiceUpdateModelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProjectId`, `Id`, `Body`
- **Query params (wire ← C#)**: `updateMask` ← `UpdateMask`
- **Returns**: `DeModel`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VolumeServiceUpdateModelRequest` | `Requests/VolumeService/VolumeServiceUpdateModelRequest.cs` |
| `DeUpdateModelRequest` | `Models/DeUpdateModelRequest.cs` |
| `DeModel` | `Models/DeModel.cs` |

