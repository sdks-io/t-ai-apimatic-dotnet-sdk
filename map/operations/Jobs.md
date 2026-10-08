<!-- Generated file — do not edit; regenerated with the SDK. -->

# Jobs — operations

Accessor: `client.Jobs` · Source: `Api/Jobs.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetJob

- **Auth**: `options.BearerAuth`
- **Signature**: `GetJob(GetJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `JobId`
- **Returns**: `JobInfoSuccessResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetJobRequest` | `Requests/Jobs/GetJobRequest.cs` |
| `JobInfoSuccessResponse` | `Models/JobInfoSuccessResponse.cs` |

### ListJobs

- **Auth**: `options.BearerAuth`
- **Signature**: `ListJobs(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `JobsInfoSuccessResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `JobsInfoSuccessResponse` | `Models/JobsInfoSuccessResponse.cs` |

