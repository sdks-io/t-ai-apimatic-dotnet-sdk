<!-- Generated file — do not edit; regenerated with the SDK. -->

# Rl — operations

Accessor: `client.Rl` · Source: `Api/Rl.cs` · 28 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateInferenceCheckpoint

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateInferenceCheckpoint(CreateInferenceCheckpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `IdempotencyKey`
- **Returns**: `RlInferenceCheckpointOperation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateInferenceCheckpointRequest` | `Requests/Rl/CreateInferenceCheckpointRequest.cs` |
| `RlInferenceCheckpointOperation` | `Models/RlInferenceCheckpointOperation.cs` |

### CreateModelResources

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateModelResources(CreateModelResourcesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RlModelResources`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateModelResourcesRequest` | `Requests/Rl/CreateModelResourcesRequest.cs` |
| `RlCreateModelResourcesRequest` | `Models/RlCreateModelResourcesRequest.cs` |
| `RlModelResources` | `Models/RlModelResources.cs` |

### CreateTrainingCheckpoint

- **Auth**: `options.BearerAuth`
- **Signature**: `CreateTrainingCheckpoint(CreateTrainingCheckpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `IdempotencyKey`
- **Returns**: `RlTrainingCheckpointOperation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreateTrainingCheckpointRequest` | `Requests/Rl/CreateTrainingCheckpointRequest.cs` |
| `RlTrainingCheckpointOperation` | `Models/RlTrainingCheckpointOperation.cs` |

### CustomForwardBackward

- **Auth**: `options.BearerAuth`
- **Signature**: `CustomForwardBackward(CustomForwardBackwardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `IdempotencyKey`, `Body`
- **Returns**: `RlCustomForwardBackwardOperation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CustomForwardBackwardRequest` | `Requests/Rl/CustomForwardBackwardRequest.cs` |
| `RlCustomForwardBackwardBody` | `Models/RlCustomForwardBackwardBody.cs` |
| `RlCustomForwardBackwardOperation` | `Models/RlCustomForwardBackwardOperation.cs` |

### DownloadCheckpoint

- **Auth**: `options.BearerAuth`
- **Signature**: `DownloadCheckpoint(DownloadCheckpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `variant` ← `Variant`
- **Returns**: `RlCheckpointDownloadResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DownloadCheckpointRequest` | `Requests/Rl/DownloadCheckpointRequest.cs` |
| `RlCheckpointVariant1` | `Models/Enums/RlCheckpointVariant1.cs` |
| `RlCheckpointDownloadResponse` | `Models/RlCheckpointDownloadResponse.cs` |

### EstimateModelResourcesCost

- **Auth**: `options.BearerAuth`
- **Signature**: `EstimateModelResourcesCost(EstimateModelResourcesCostRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RlModelResourcesEstimateCostResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EstimateModelResourcesCostRequest` | `Requests/Rl/EstimateModelResourcesCostRequest.cs` |
| `RlCreateModelResourcesRequest` | `Models/RlCreateModelResourcesRequest.cs` |
| `RlModelResourcesEstimateCostResponse` | `Models/RlModelResourcesEstimateCostResponse.cs` |

### ForwardBackward

- **Auth**: `options.BearerAuth`
- **Signature**: `ForwardBackward(ForwardBackwardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `IdempotencyKey`, `Body`
- **Returns**: `RlForwardBackwardOperation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ForwardBackwardRequest` | `Requests/Rl/ForwardBackwardRequest.cs` |
| `RlForwardBackwardBody` | `Models/RlForwardBackwardBody.cs` |
| `RlForwardBackwardOperation` | `Models/RlForwardBackwardOperation.cs` |

### GetCheckpoint

- **Auth**: `options.BearerAuth`
- **Signature**: `GetCheckpoint(GetCheckpointRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `RlCheckpoint`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetCheckpointRequest` | `Requests/Rl/GetCheckpointRequest.cs` |
| `RlCheckpoint` | `Models/RlCheckpoint.cs` |

### GetCustomForwardBackwardOperation

- **Auth**: `options.BearerAuth`
- **Signature**: `GetCustomForwardBackwardOperation(GetCustomForwardBackwardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `OperationId`
- **Returns**: `RlCustomForwardBackwardOperation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetCustomForwardBackwardOperationRequest` | `Requests/Rl/GetCustomForwardBackwardOperationRequest.cs` |
| `RlCustomForwardBackwardOperation` | `Models/RlCustomForwardBackwardOperation.cs` |

### GetForwardBackwardOperation

- **Auth**: `options.BearerAuth`
- **Signature**: `GetForwardBackwardOperation(GetForwardBackwardOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `OperationId`
- **Returns**: `RlForwardBackwardOperation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetForwardBackwardOperationRequest` | `Requests/Rl/GetForwardBackwardOperationRequest.cs` |
| `RlForwardBackwardOperation` | `Models/RlForwardBackwardOperation.cs` |

### GetInferenceCheckpointOperation

- **Auth**: `options.BearerAuth`
- **Signature**: `GetInferenceCheckpointOperation(GetInferenceCheckpointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `OperationId`
- **Returns**: `RlInferenceCheckpointOperation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetInferenceCheckpointOperationRequest` | `Requests/Rl/GetInferenceCheckpointOperationRequest.cs` |
| `RlInferenceCheckpointOperation` | `Models/RlInferenceCheckpointOperation.cs` |

### GetModelResources

- **Auth**: `options.BearerAuth`
- **Signature**: `GetModelResources(GetModelResourcesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ModelResourcesId`
- **Returns**: `RlModelResources`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetModelResourcesRequest` | `Requests/Rl/GetModelResourcesRequest.cs` |
| `RlModelResources` | `Models/RlModelResources.cs` |

### GetOptimStepOperation

- **Auth**: `options.BearerAuth`
- **Signature**: `GetOptimStepOperation(GetOptimStepOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `OperationId`
- **Returns**: `RlOptimStepOperation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetOptimStepOperationRequest` | `Requests/Rl/GetOptimStepOperationRequest.cs` |
| `RlOptimStepOperation` | `Models/RlOptimStepOperation.cs` |

### GetSample

- **Auth**: `options.BearerAuth`
- **Signature**: `GetSample(GetSampleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `OperationId`
- **Returns**: `RlSampleOperation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetSampleRequest` | `Requests/Rl/GetSampleRequest.cs` |
| `RlSampleOperation` | `Models/RlSampleOperation.cs` |

### GetTrainingCheckpointOperation

- **Auth**: `options.BearerAuth`
- **Signature**: `GetTrainingCheckpointOperation(GetTrainingCheckpointOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `OperationId`
- **Returns**: `RlTrainingCheckpointOperation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTrainingCheckpointOperationRequest` | `Requests/Rl/GetTrainingCheckpointOperationRequest.cs` |
| `RlTrainingCheckpointOperation` | `Models/RlTrainingCheckpointOperation.cs` |

### GetTrainingSession

- **Auth**: `options.BearerAuth`
- **Signature**: `GetTrainingSession(GetTrainingSessionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`
- **Returns**: `RlTrainingSession`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTrainingSessionRequest` | `Requests/Rl/GetTrainingSessionRequest.cs` |
| `RlTrainingSession` | `Models/RlTrainingSession.cs` |

### GetWeightsSyncOperation

- **Auth**: `options.BearerAuth`
- **Signature**: `GetWeightsSyncOperation(GetWeightsSyncOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `OperationId`
- **Returns**: `RlWeightsSyncOperation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetWeightsSyncOperationRequest` | `Requests/Rl/GetWeightsSyncOperationRequest.cs` |
| `RlWeightsSyncOperation` | `Models/RlWeightsSyncOperation.cs` |

### ListCheckpoints

- **Auth**: `options.BearerAuth`
- **Signature**: `ListCheckpoints(ListCheckpointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `session_id` ← `SessionId`, `base_model` ← `BaseModel`, `limit` ← `Limit`, `after` ← `After`
- **Returns**: `RlCheckpointsListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListCheckpointsRequest` | `Requests/Rl/ListCheckpointsRequest.cs` |
| `RlCheckpointsListResponse` | `Models/RlCheckpointsListResponse.cs` |

### ListModelResources

- **Auth**: `options.BearerAuth`
- **Signature**: `ListModelResources(ListModelResourcesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `status` ← `Status`, `limit` ← `Limit`, `after` ← `After`, `created_by` ← `CreatedBy`
- **Returns**: `RlModelResourcesListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListModelResourcesRequest` | `Requests/Rl/ListModelResourcesRequest.cs` |
| `Status12` | `Models/Enums/Status12.cs` |
| `RlModelResourcesListResponse` | `Models/RlModelResourcesListResponse.cs` |

### ListSupportedModels

- **Auth**: `options.BearerAuth`
- **Signature**: `ListSupportedModels(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `RlSupportedModelsListResponse`
- **Error**: `ApiException<ListSupportedModelsError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorData(out ErrorData)` [429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RlSupportedModelsListResponse` | `Models/RlSupportedModelsListResponse.cs` |
| `ListSupportedModelsError` | `Errors/ListSupportedModelsError.cs` |
| `ErrorData` | `Models/ErrorData.cs` |

### ListTrainingSessions

- **Auth**: `options.BearerAuth`
- **Signature**: `ListTrainingSessions(ListTrainingSessionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `status` ← `Status`, `limit` ← `Limit`, `after` ← `After`, `model_resources_id` ← `ModelResourcesId`, `created_by` ← `CreatedBy`
- **Returns**: `RlTrainingSessionsListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListTrainingSessionsRequest` | `Requests/Rl/ListTrainingSessionsRequest.cs` |
| `Status13` | `Models/Enums/Status13.cs` |
| `RlTrainingSessionsListResponse` | `Models/RlTrainingSessionsListResponse.cs` |

### OptimStep

- **Auth**: `options.BearerAuth`
- **Signature**: `OptimStep(OptimStepRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `IdempotencyKey`, `Body`
- **Returns**: `RlOptimStepOperation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OptimStepRequest` | `Requests/Rl/OptimStepRequest.cs` |
| `RlOptimStepBody` | `Models/RlOptimStepBody.cs` |
| `RlOptimStepOperation` | `Models/RlOptimStepOperation.cs` |

### Sample

- **Auth**: `options.BearerAuth`
- **Signature**: `Sample(SampleRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `IdempotencyKey`, `Body`
- **Returns**: `RlSampleOperation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SampleRequest` | `Requests/Rl/SampleRequest.cs` |
| `RlSampleBody` | `Models/RlSampleBody.cs` |
| `RlSampleOperation` | `Models/RlSampleOperation.cs` |

### StartTrainingSession

- **Auth**: `options.BearerAuth`
- **Signature**: `StartTrainingSession(StartTrainingSessionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `RlTrainingSession`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StartTrainingSessionRequest` | `Requests/Rl/StartTrainingSessionRequest.cs` |
| `RlStartTrainingSessionRequest` | `Models/RlStartTrainingSessionRequest.cs` |
| `RlTrainingSession` | `Models/RlTrainingSession.cs` |

### StopModelResources

- **Auth**: `options.BearerAuth`
- **Signature**: `StopModelResources(StopModelResourcesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ModelResourcesId`
- **Query params (wire ← C#)**: `force` ← `Force`
- **Returns**: `RlModelResources`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StopModelResourcesRequest` | `Requests/Rl/StopModelResourcesRequest.cs` |
| `RlModelResources` | `Models/RlModelResources.cs` |

### StopTrainingSession

- **Auth**: `options.BearerAuth`
- **Signature**: `StopTrainingSession(StopTrainingSessionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`
- **Returns**: `RlTrainingSession`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StopTrainingSessionRequest` | `Requests/Rl/StopTrainingSessionRequest.cs` |
| `RlTrainingSession` | `Models/RlTrainingSession.cs` |

### UpdateTrainingSession

- **Auth**: `options.BearerAuth`
- **Signature**: `UpdateTrainingSession(UpdateTrainingSessionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `Body`
- **Returns**: `RlTrainingSession`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateTrainingSessionRequest` | `Requests/Rl/UpdateTrainingSessionRequest.cs` |
| `RlUpdateTrainingSessionRequest` | `Models/RlUpdateTrainingSessionRequest.cs` |
| `RlTrainingSession` | `Models/RlTrainingSession.cs` |

### WeightsSync

- **Auth**: `options.BearerAuth`
- **Signature**: `WeightsSync(WeightsSyncRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `IdempotencyKey`, `Body`
- **Returns**: `RlWeightsSyncOperation`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WeightsSyncRequest` | `Requests/Rl/WeightsSyncRequest.cs` |
| `RlWeightsSyncBody` | `Models/RlWeightsSyncBody.cs` |
| `RlWeightsSyncOperation` | `Models/RlWeightsSyncOperation.cs` |

