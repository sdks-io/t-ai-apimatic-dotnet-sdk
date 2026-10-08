<!-- Generated file — do not edit; regenerated with the SDK. -->

# DeploymentsStorage — operations

Accessor: `client.DeploymentsStorage` · Source: `Api/DeploymentsStorage.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DownloadAFile

- **Auth**: `options.BearerAuth`
- **Signature**: `DownloadAFile(DownloadAFileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Filename`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DownloadAFileError>` — **Case A (typed)**
- **Error accessors**: `TryGetMapOfString(out IReadOnlyDictionary<string, string>)` [400, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DownloadAFileRequest` | `Requests/DeploymentsStorage/DownloadAFileRequest.cs` |
| `DownloadAFileError` | `Errors/DownloadAFileError.cs` |

### GetAFileDownloadUrl

- **Auth**: `options.BearerAuth`
- **Signature**: `GetAFileDownloadUrl(GetAFileDownloadUrlRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Filename`
- **Returns**: `SignedUrlResponse`
- **Error**: `ApiException<GetAFileDownloadUrlError>` — **Case A (typed)**
- **Error accessors**: `TryGetMapOfString(out IReadOnlyDictionary<string, string>)` [400, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAFileDownloadUrlRequest` | `Requests/DeploymentsStorage/GetAFileDownloadUrlRequest.cs` |
| `SignedUrlResponse` | `Models/SignedUrlResponse.cs` |
| `GetAFileDownloadUrlError` | `Errors/GetAFileDownloadUrlError.cs` |

