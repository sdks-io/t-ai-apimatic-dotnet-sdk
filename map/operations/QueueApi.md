<!-- Generated file — do not edit; regenerated with the SDK. -->

# QueueApi — operations

Accessor: `client.QueueApi` · Source: `Api/QueueApi.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelQueueJob

- **Auth**: `options.BearerAuth`
- **Signature**: `CancelQueueJob(CancelQueueJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `QueueCancelResponse`
- **Error**: `ApiException<CancelQueueJobError>` — **Case A (typed)**
- **Error accessors**: `TryGetQueueError(out QueueError)` [400, 404, 500] · `TryGetQueueCancelResponse(out QueueCancelResponse)` [409] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelQueueJobRequest` | `Requests/QueueApi/CancelQueueJobRequest.cs` |
| `QueueCancelRequest` | `Models/QueueCancelRequest.cs` |
| `QueueCancelResponse` | `Models/QueueCancelResponse.cs` |
| `CancelQueueJobError` | `Errors/CancelQueueJobError.cs` |
| `QueueError` | `Models/QueueError.cs` |

### ClearQueue

- **Auth**: `options.BearerAuth`
- **Signature**: `ClearQueue(ClearQueueRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `QueueClearResponse`
- **Error**: `ApiException<ClearQueueError>` — **Case A (typed)**
- **Error accessors**: `TryGetQueueError(out QueueError)` [400, 401, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClearQueueRequest` | `Requests/QueueApi/ClearQueueRequest.cs` |
| `QueueClearRequest` | `Models/QueueClearRequest.cs` |
| `QueueClearResponse` | `Models/QueueClearResponse.cs` |
| `ClearQueueError` | `Errors/ClearQueueError.cs` |
| `QueueError` | `Models/QueueError.cs` |

### GetQueueJobStatus

- **Auth**: `options.BearerAuth`
- **Signature**: `GetQueueJobStatus(GetQueueJobStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `RequestId`, `Model`
- **Query params (wire ← C#)**: `request_id` ← `RequestId`, `model` ← `Model`
- **Returns**: `QueueJobStatusResponse`
- **Error**: `ApiException<GetQueueJobStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetQueueError(out QueueError)` [400, 401, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetQueueJobStatusRequest` | `Requests/QueueApi/GetQueueJobStatusRequest.cs` |
| `QueueJobStatusResponse` | `Models/QueueJobStatusResponse.cs` |
| `GetQueueJobStatusError` | `Errors/GetQueueJobStatusError.cs` |
| `QueueError` | `Models/QueueError.cs` |

### GetQueueMetrics

- **Auth**: `options.BearerAuth`
- **Signature**: `GetQueueMetrics(GetQueueMetricsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Model`
- **Query params (wire ← C#)**: `model` ← `Model`
- **Returns**: `QueueMetricsResponse`
- **Error**: `ApiException<GetQueueMetricsError>` — **Case A (typed)**
- **Error accessors**: `TryGetQueueError(out QueueError)` [400, 401, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetQueueMetricsRequest` | `Requests/QueueApi/GetQueueMetricsRequest.cs` |
| `QueueMetricsResponse` | `Models/QueueMetricsResponse.cs` |
| `GetQueueMetricsError` | `Errors/GetQueueMetricsError.cs` |
| `QueueError` | `Models/QueueError.cs` |

### SubmitQueueJob

- **Auth**: `options.BearerAuth`
- **Signature**: `SubmitQueueJob(SubmitQueueJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `QueueJobResponse`
- **Error**: `ApiException<SubmitQueueJobError>` — **Case A (typed)**
- **Error accessors**: `TryGetQueueError(out QueueError)` [400, 401, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubmitQueueJobRequest` | `Requests/QueueApi/SubmitQueueJobRequest.cs` |
| `QueueJobRequest` | `Models/QueueJobRequest.cs` |
| `QueueJobResponse` | `Models/QueueJobResponse.cs` |
| `SubmitQueueJobError` | `Errors/SubmitQueueJobError.cs` |
| `QueueError` | `Models/QueueError.cs` |

