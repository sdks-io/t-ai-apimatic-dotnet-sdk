<!-- Generated file — do not edit; regenerated with the SDK. -->

# FineTuning — operations

Accessor: `client.FineTuning` · Source: `Api/FineTuning.cs` · 14 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelJob

- **Auth**: `options.BearerAuth`
- **Signature**: `CancelJob(CancelJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `FinetuneResponseTruncated`
- **Error**: `ApiException<CancelJobError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelJobRequest` | `Requests/FineTuning/CancelJobRequest.cs` |
| `FinetuneResponseTruncated` | `Models/FinetuneResponseTruncated.cs` |
| `CancelJobError` | `Errors/CancelJobError.cs` |

### CreateJob

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateJob(CreateJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `FinetuneResponseTruncated`
- **Error**: `ApiException<CreateJobError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateJobRequest` | `Requests/FineTuning/CreateJobRequest.cs` |
| `FineTunesRequest` | `Models/FineTunesRequest.cs` |
| `FinetuneResponseTruncated` | `Models/FinetuneResponseTruncated.cs` |
| `CreateJobError` | `Errors/CreateJobError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### DeleteAFineTuneJob

- **Auth**: `options.BearerAuth`
- **Signature**: `DeleteAFineTuneJob(DeleteAFineTuneJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `force` ← `Force`
- **Returns**: `FinetuneDeleteResponse`
- **Error**: `ApiException<DeleteAFineTuneJobError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteAFineTuneJobRequest` | `Requests/FineTuning/DeleteAFineTuneJobRequest.cs` |
| `FinetuneDeleteResponse` | `Models/FinetuneDeleteResponse.cs` |
| `DeleteAFineTuneJobError` | `Errors/DeleteAFineTuneJobError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### DownloadModel

- **Auth**: `options.BearerAuth`
- **Signature**: `DownloadModel(DownloadModelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `FtId`
- **Query params (wire ← C#)**: `ft_id` ← `FtId`, `checkpoint_step` ← `CheckpointStep`, `checkpoint` ← `Checkpoint`
- **Returns**: `BinaryContent`
- **Error**: `ApiException<DownloadModelError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DownloadModelRequest` | `Requests/FineTuning/DownloadModelRequest.cs` |
| `Checkpoint1` | `Models/Enums/Checkpoint1.cs` |
| `DownloadModelError` | `Errors/DownloadModelError.cs` |

### DownloadTokenizedDataset

- **Auth**: `options.BearerAuth`
- **Signature**: `DownloadTokenizedDataset(DownloadTokenizedDatasetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `FineTuneTokenizedDatasetRetrieveResponse`
- **Error**: `ApiException<DownloadTokenizedDatasetError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DownloadTokenizedDatasetRequest` | `Requests/FineTuning/DownloadTokenizedDatasetRequest.cs` |
| `FineTuneTokenizedDatasetRetrieveResponse` | `Models/FineTuneTokenizedDatasetRetrieveResponse.cs` |
| `DownloadTokenizedDatasetError` | `Errors/DownloadTokenizedDatasetError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### EstimatePrice

- **Auth**: `options.BearerAuth`
- **Signature**: `EstimatePrice(EstimatePriceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `FineTunesEstimatePriceResponse2`
- **Error**: `ApiException<EstimatePriceError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EstimatePriceRequest` | `Requests/FineTuning/EstimatePriceRequest.cs` |
| `FineTunesEstimatePriceRequest` | `Models/FineTunesEstimatePriceRequest.cs` |
| `FineTunesEstimatePriceResponse2` | `Models/AnyOf/FineTunesEstimatePriceResponse2.cs` |
| `EstimatePriceError` | `Errors/EstimatePriceError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### GetFineTunesByIdByCheckpoints

- **Auth**: `options.BearerAuth`
- **Signature**: `GetFineTunesByIdByCheckpoints(GetFineTunesByIdByCheckpointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `FinetuneListCheckpoints`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetFineTunesByIdByCheckpointsRequest` | `Requests/FineTuning/GetFineTunesByIdByCheckpointsRequest.cs` |
| `FinetuneListCheckpoints` | `Models/FinetuneListCheckpoints.cs` |

### GetFineTunesModelsSupported

- **Auth**: `options.BearerAuth`
- **Signature**: `GetFineTunesModelsSupported(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `FineTunesModelsSupportedResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FineTunesModelsSupportedResponse` | `Models/FineTunesModelsSupportedResponse.cs` |

### GetMetrics

- **Auth**: `options.BearerAuth`
- **Signature**: `GetMetrics(GetMetricsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `global_step_from` ← `GlobalStepFrom`, `global_step_to` ← `GlobalStepTo`, `logged_at_from` ← `LoggedAtFrom`, `logged_at_to` ← `LoggedAtTo`, `resolution` ← `Resolution`
- **Returns**: `FineTunesMetricsResponse`
- **Error**: `ApiException<GetMetricsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMetricsRequest` | `Requests/FineTuning/GetMetricsRequest.cs` |
| `FineTunesMetricsResponse` | `Models/FineTunesMetricsResponse.cs` |
| `GetMetricsError` | `Errors/GetMetricsError.cs` |

### GetModelLimits

- **Auth**: `options.BearerAuth`
- **Signature**: `GetModelLimits(GetModelLimitsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ModelName`
- **Query params (wire ← C#)**: `model_name` ← `ModelName`
- **Returns**: `FineTuneModelLimits`
- **Error**: `ApiException<GetModelLimitsError>` — **Case A (typed)**
- **Error accessors**: `TryGetFineTunesModelsLimits404Error1(out FineTunesModelsLimits404Error1)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetModelLimitsRequest` | `Requests/FineTuning/GetModelLimitsRequest.cs` |
| `FineTuneModelLimits` | `Models/FineTuneModelLimits.cs` |
| `GetModelLimitsError` | `Errors/GetModelLimitsError.cs` |
| `FineTunesModelsLimits404Error1` | `Models/FineTunesModelsLimits404Error1.cs` |

### ListAllJobs

- **Auth**: `options.BearerAuth`
- **Signature**: `ListAllJobs(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `FinetuneTruncatedList`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FinetuneTruncatedList` | `Models/FinetuneTruncatedList.cs` |

### ListJob

- **Auth**: `options.BearerAuth`
- **Signature**: `ListJob(ListJobRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `FinetuneResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListJobRequest` | `Requests/FineTuning/ListJobRequest.cs` |
| `FinetuneResponse` | `Models/FinetuneResponse.cs` |

### ListJobEvents

- **Auth**: `options.BearerAuth`
- **Signature**: `ListJobEvents(ListJobEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `FinetuneListEvents`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListJobEventsRequest` | `Requests/FineTuning/ListJobEventsRequest.cs` |
| `FinetuneListEvents` | `Models/FinetuneListEvents.cs` |

### PreviewTokenizedData

- **Auth**: `options.BearerAuth`
- **Signature**: `PreviewTokenizedData(PreviewTokenizedDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `FineTunePreviewResponse`
- **Error**: `ApiException<PreviewTokenizedDataError>` — **Case A (typed)**
- **Error accessors**: `TryGetFineTunesPreviewResponse(out FineTunesPreviewResponse)` [400] · `TryGetErrorData(out ErrorData)` [401, 404] · `TryGetFineTunePreviewMessageError(out FineTunePreviewMessageError)` [500, 502] · `TryGetFineTunePreviewDetailError(out FineTunePreviewDetailError)` [503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PreviewTokenizedDataRequest` | `Requests/FineTuning/PreviewTokenizedDataRequest.cs` |
| `FineTunePreviewRequest` | `Models/FineTunePreviewRequest.cs` |
| `FineTunePreviewResponse` | `Models/FineTunePreviewResponse.cs` |
| `PreviewTokenizedDataError` | `Errors/PreviewTokenizedDataError.cs` |
| `FineTunesPreviewResponse` | `Models/AnyOf/FineTunesPreviewResponse.cs` |
| `ErrorData` | `Models/ErrorData.cs` |
| `FineTunePreviewMessageError` | `Models/FineTunePreviewMessageError.cs` |
| `FineTunePreviewDetailError` | `Models/FineTunePreviewDetailError.cs` |

