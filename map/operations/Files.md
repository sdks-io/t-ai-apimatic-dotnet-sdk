<!-- Generated file — do not edit; regenerated with the SDK. -->

# Files — operations

Accessor: `client.Files` · Source: `Api/Files.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteAFile

- **Auth**: `options.BearerAuth`
- **Signature**: `DeleteAFile(DeleteAFileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `FileDeleteResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteAFileRequest` | `Requests/Files/DeleteAFileRequest.cs` |
| `FileDeleteResponse` | `Models/FileDeleteResponse.cs` |

### GetFileContents

- **Auth**: `options.BearerAuth`
- **Signature**: `GetFileContents(GetFileContentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<GetFileContentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFileContentsRequest` | `Requests/Files/GetFileContentsRequest.cs` |
| `GetFileContentsError` | `Errors/GetFileContentsError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### ListAllFiles

- **Auth**: `options.BearerAuth`
- **Signature**: `ListAllFiles(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `FileList`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FileList` | `Models/FileList.cs` |

### RetrieveFileMetadata

- **Auth**: `options.BearerAuth`
- **Signature**: `RetrieveFileMetadata(RetrieveFileMetadataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `FileResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RetrieveFileMetadataRequest` | `Requests/Files/RetrieveFileMetadataRequest.cs` |
| `FileResponse` | `Models/FileResponse.cs` |

### UploadAFile

- **Auth**: `options.BearerAuth`
- **Signature**: `UploadAFile(UploadAFileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Purpose`, `FileName`, `File`
- **Returns**: `FileResponse`
- **Error**: `ApiException<UploadAFileError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400, 401, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UploadAFileRequest` | `Requests/Files/UploadAFileRequest.cs` |
| `FilePurpose` | `Models/Enums/FilePurpose.cs` |
| `FileType` | `Models/Enums/FileType.cs` |
| `FileResponse` | `Models/FileResponse.cs` |
| `UploadAFileError` | `Errors/UploadAFileError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

