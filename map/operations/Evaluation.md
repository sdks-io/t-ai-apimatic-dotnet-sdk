<!-- Generated file — do not edit; regenerated with the SDK. -->

# Evaluation — operations

Accessor: `client.Evaluation` · Source: `Api/Evaluation.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateEvaluationJob

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateEvaluationJob(CreateEvaluationJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `EvaluationResponse`
- **Error**: `ApiException<CreateEvaluationJobError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateEvaluationJobRequest` | `Requests/Evaluation/CreateEvaluationJobRequest.cs` |
| `EvaluationTypedRequest` | `Models/EvaluationTypedRequest.cs` |
| `EvaluationResponse` | `Models/EvaluationResponse.cs` |
| `CreateEvaluationJobError` | `Errors/CreateEvaluationJobError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### GetAllEvaluationJobs

- **Auth**: `options.BearerAuth`
- **Signature**: `GetAllEvaluationJobs(GetAllEvaluationJobsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `status` ← `Status`, `limit` ← `Limit`
- **Returns**: `IReadOnlyList<EvaluationJob>`
- **Error**: `ApiException<GetAllEvaluationJobsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAllEvaluationJobsRequest` | `Requests/Evaluation/GetAllEvaluationJobsRequest.cs` |
| `EvaluationJob` | `Models/EvaluationJob.cs` |
| `GetAllEvaluationJobsError` | `Errors/GetAllEvaluationJobsError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### GetEvaluationJobDetails

- **Auth**: `options.BearerAuth`
- **Signature**: `GetEvaluationJobDetails(GetEvaluationJobDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `EvaluationJob`
- **Error**: `ApiException<GetEvaluationJobDetailsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEvaluationJobDetailsRequest` | `Requests/Evaluation/GetEvaluationJobDetailsRequest.cs` |
| `EvaluationJob` | `Models/EvaluationJob.cs` |
| `GetEvaluationJobDetailsError` | `Errors/GetEvaluationJobDetailsError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### GetEvaluationJobStatusAndResults

- **Auth**: `options.BearerAuth`
- **Signature**: `GetEvaluationJobStatusAndResults(GetEvaluationJobStatusAndResultsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `EvaluationStatusResponse`
- **Error**: `ApiException<GetEvaluationJobStatusAndResultsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetEvaluationJobStatusAndResultsRequest` | `Requests/Evaluation/GetEvaluationJobStatusAndResultsRequest.cs` |
| `EvaluationStatusResponse` | `Models/EvaluationStatusResponse.cs` |
| `GetEvaluationJobStatusAndResultsError` | `Errors/GetEvaluationJobStatusAndResultsError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### GetModelList

- **Auth**: `options.BearerAuth`
- **Signature**: `GetModelList(GetModelListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `model_source` ← `ModelSource`
- **Returns**: `EvaluationModelListResponse`
- **Error**: `ApiException<GetModelListError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [400, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetModelListRequest` | `Requests/Evaluation/GetModelListRequest.cs` |
| `EvaluationModelListResponse` | `Models/EvaluationModelListResponse.cs` |
| `GetModelListError` | `Errors/GetModelListError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

