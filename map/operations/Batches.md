<!-- Generated file — do not edit; regenerated with the SDK. -->

# Batches — operations

Accessor: `client.Batches` · Source: `Api/Batches.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelABatchJob

- **Auth**: `options.BearerAuth`
- **Signature**: `CancelABatchJob(CancelABatchJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `BatchJob`
- **Error**: `ApiException<CancelABatchJobError>` — **Case A (typed)**
- **Error accessors**: `TryGetBatchErrorResponse(out BatchErrorResponse)` [400, 401, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelABatchJobRequest` | `Requests/Batches/CancelABatchJobRequest.cs` |
| `BatchJob` | `Models/BatchJob.cs` |
| `CancelABatchJobError` | `Errors/CancelABatchJobError.cs` |
| `BatchErrorResponse` | `Models/BatchErrorResponse.cs` |

### CreateABatchJob

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateABatchJob(CreateABatchJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BatchJobWithWarning`
- **Error**: `ApiException<CreateABatchJobError>` — **Case A (typed)**
- **Error accessors**: `TryGetBatchErrorResponse(out BatchErrorResponse)` [400, 401, 429, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateABatchJobRequest` | `Requests/Batches/CreateABatchJobRequest.cs` |
| `CreateBatchRequest` | `Models/CreateBatchRequest.cs` |
| `BatchJobWithWarning` | `Models/BatchJobWithWarning.cs` |
| `CreateABatchJobError` | `Errors/CreateABatchJobError.cs` |
| `BatchErrorResponse` | `Models/BatchErrorResponse.cs` |

### GetABatchJob

- **Auth**: `options.BearerAuth`
- **Signature**: `GetABatchJob(GetABatchJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `BatchJob`
- **Error**: `ApiException<GetABatchJobError>` — **Case A (typed)**
- **Error accessors**: `TryGetBatchErrorResponse(out BatchErrorResponse)` [400, 401, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetABatchJobRequest` | `Requests/Batches/GetABatchJobRequest.cs` |
| `BatchJob` | `Models/BatchJob.cs` |
| `GetABatchJobError` | `Errors/GetABatchJobError.cs` |
| `BatchErrorResponse` | `Models/BatchErrorResponse.cs` |

### ListBatchJobs

- **Auth**: `options.BearerAuth`
- **Signature**: `ListBatchJobs(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<BatchJob>`
- **Error**: `ApiException<ListBatchJobsError>` — **Case A (typed)**
- **Error accessors**: `TryGetBatchErrorResponse(out BatchErrorResponse)` [401, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BatchJob` | `Models/BatchJob.cs` |
| `ListBatchJobsError` | `Errors/ListBatchJobsError.cs` |
| `BatchErrorResponse` | `Models/BatchErrorResponse.cs` |

